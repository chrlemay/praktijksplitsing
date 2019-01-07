using Core;
using Quizes.DataBase;
using System;
using System.Linq;

namespace Quizes
{
    public class SessionConductor
    {
        private Session Session { get; set; }

        public SessionConductor()
        {
            Session = new Session();
        }
      
        public void Start()
        {
            while (ChooseQuiz())
            {
                Session.Start();
            }
        }

        private bool ChooseQuiz()
        {
            var buildingBlockKeys = BuildingBlocksBase.BuildingBlocks.Keys.ToArray();

            if (buildingBlockKeys == null)
            {
                throw new InvalidOperationException("Building Blocks Are Empty");
            }

            var choiceString = ConsoleAid.GetChoicePossibility("Kies een Building Block", buildingBlockKeys, "stop", out int choice);

            if (choice == 0)
            {
                return false;
            }

            Console.Clear();

            var quizes = BuildingBlocksBase.BuildingBlocks[choiceString];

            if (quizes == null)
            {
                throw new InvalidOperationException($"Quizes of '{choiceString}' Are empty");
            }

            var quizTitles = quizes.Select(x => x.Item1).ToArray();

            choice = ConsoleAid.GetChoice("Kies een Quiz", quizTitles, "stop");

            if (choice == 0)
            {
                return false;
            }

            Console.Clear();

            var quiz = quizes[choice - 1];

            Session.Reset(quiz.Item2);

            return true;
        }
    }
}
