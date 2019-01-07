using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_11Leeftijd : ExerciseBase
    {
        public override void RunExercise()
        {
            int leeftijd = 0;
            string naam;

            Console.WriteLine("Geef je naam in: ");
            naam = Console.ReadLine();

            Console.WriteLine("Geef je leeftijd in: ");
            leeftijd = int.Parse(Console.ReadLine()); ;

            switch (leeftijd / 10)
            {
                case 0:
                    Console.WriteLine($"{naam} heeft een leeftijd tussen de 0 en de 10 jaar");
                    break;
                case 1:
                    Console.WriteLine($"{naam} heeft een leeftijd tussen de 11 en de 20 jaar");
                    break;
                case 2:
                    Console.WriteLine($"{naam} heeft een leeftijd tussen de 21 en de 30 jaar");
                    break;
                case 3:
                    Console.WriteLine($"{naam}  heeft een leeftijd tussen de 31 en de 40 jaar");
                    break;
                case 4:
                    Console.WriteLine($"{naam} heeft een leeftijd tussen de 41 en de 50 jaar");
                    break;
                case 5:
                    Console.WriteLine($"{naam} heeft een leeftijd tussen de 51 en de 60 jaar");
                    break;
                case 6:
                    Console.WriteLine($"{naam} heeft een leeftijd tussen de 61 en de 70 jaar");
                    break;
                case 7:
                    Console.WriteLine($"{naam} heeft een leeftijd tussen de 71 en de 80 jaar");
                    break;
                case 8:
                    Console.WriteLine($"{naam} heeft een leeftijd tussen de 81 en de 90 jaar");
                    break;
                case 9:
                    Console.WriteLine($"{naam} heeft een leeftijd tussen de 91 en de 100 jaar");
                    break;
                default:
                    Console.WriteLine("Foutief!");
                    break;
            }
        }
    }
}
