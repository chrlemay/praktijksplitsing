using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_10DagenPerMaand : ExerciseBase
    {
        public override void RunExercise()
        {
            int maand = 0;
            int jaar = 0;
            int aantalDagen = 0;

            Console.WriteLine("Geef een getal in voor een maand: ");
            maand = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef een jaartal in: ");
            jaar = int.Parse(Console.ReadLine());

            switch (maand)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    aantalDagen = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    aantalDagen = 30;
                    break;
                case 2:
                    if (((jaar % 4 == 0) && !(jaar % 100 == 0)) || (jaar % 400 == 0))
                        aantalDagen = 29;
                    else
                        aantalDagen = 28;
                    break;
                default:
                    Console.WriteLine("Ongeldige ingave van een maand");
                    break;
            }

            Console.WriteLine("Aantal dagen = " + aantalDagen);
        }
    }
}
