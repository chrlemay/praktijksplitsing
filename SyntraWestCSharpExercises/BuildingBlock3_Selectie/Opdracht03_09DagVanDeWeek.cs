using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_09DagVanDeWeek : ExerciseBase
    {
        public override void RunExercise()
        {
            int getalDag = 0;
            string dag = "";

            Console.WriteLine("Geef een getal in voor een dag: ");
            getalDag = int.Parse(Console.ReadLine());

            switch (getalDag)
            {
                case 1:
                    dag = "Maandag";
                    break;
                case 2:
                    dag = "Dinsdag";
                    break;
                case 3:
                    dag = "Woensdag";
                    break;
                case 4:
                    dag = "Donderdag";
                    break;
                case 5:
                    dag = "Vrijdag";
                    break;
                case 6:
                    dag = "Zaterdag";
                    break;
                case 7:
                    dag = "Zondag";
                    break;

                default:
                    dag = "geen getal voor een dag ingegeven";
                    break;
            }

            Console.WriteLine("De gekozen dag = " + dag);
            Console.WriteLine("\n");
        }
    }
}
