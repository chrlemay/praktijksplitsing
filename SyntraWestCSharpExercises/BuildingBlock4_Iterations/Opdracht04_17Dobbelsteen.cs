using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_17Dobbelsteen : ExerciseBase
    {
        public override void RunExercise()
        {
            Random dobbelsteen = new Random();

            string naamSpeler1;
            string naamSpeler2;
            int dobbelSpeler1, dobbelSpeler2;
            int puntenSpeler1 = 0;
            int puntenSpeler2 = 0;
            
            Console.WriteLine("Naam speler 1: ");
            naamSpeler1 = Console.ReadLine();

            Console.WriteLine("Naam speler 2: ");
            naamSpeler2 = Console.ReadLine();

            do
            {
                dobbelSpeler1 = 0;
                dobbelSpeler2 = 0;

                Console.WriteLine();

                while (dobbelSpeler1 != 6 && dobbelSpeler2 != 6)
                {
                    Console.WriteLine("Volgende Ronde");
                    dobbelSpeler1 = dobbelsteen.Next(1,7);
                    Console.WriteLine($"{naamSpeler1} gooit {dobbelSpeler1}");
                    
                    dobbelSpeler2 = dobbelsteen.Next(1, 7);
                    Console.WriteLine(value: naamSpeler2 + " gooit " + dobbelSpeler2);
                }

                Console.WriteLine("er heeft iemand 6 gesmeten");

                if (dobbelSpeler1 == 6)
                {
                    puntenSpeler1++;
                }

                if (dobbelSpeler2 == 6)
                {
                    puntenSpeler2++;
                }

                Console.WriteLine($"{naamSpeler1}:\t{puntenSpeler1}\t{naamSpeler2}:\t{puntenSpeler2}");
            }
            while (puntenSpeler1 < 3 && puntenSpeler2 < 3);
            
            Console.WriteLine($"{(puntenSpeler1 >= 3 ? naamSpeler1 : naamSpeler2)} is gewonnen");
        }
    }
}
