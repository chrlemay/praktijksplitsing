using System;

namespace SyntraWestCSharpExercises.BuildingBlock5_Arrays
{
    public class Opdracht05_15Boerderijdieren : ExerciseBase
    {
        public override void RunExercise()
        {
            string[] boerderijDieren = { "kip", "koe", "paard", "geit", "schaap" };
            bool gevonden = false;

            Console.WriteLine("Geef het dier ");
            string dier = Console.ReadLine();

            foreach (string boerderijDier in boerderijDieren)
            {
                if (boerderijDier == dier)
                {
                    gevonden = true;
                    break;
                }
            }

            if (gevonden)
            {
                Console.WriteLine("Dat is een boerderijdier!");
            }
            else
            {
                Console.WriteLine("Dat is geen boerderijdier");
            }
        }
    }
}
