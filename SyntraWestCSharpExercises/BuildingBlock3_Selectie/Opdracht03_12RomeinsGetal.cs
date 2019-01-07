using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_12RomeinsGetal : ExerciseBase
    {
        public override void RunExercise()
        {
            char letter = ' ';
            int getal = 0;

            Console.WriteLine("Geef een romeins getal in: ");
            letter = char.Parse(Console.ReadLine());

            switch (letter)
            {
                case 'I':
                    getal = 1;
                    break;
                case 'V':
                    getal = 5;
                    break;
                case 'X':
                    getal = 10;
                    break;
                case 'L':
                    getal = 50;
                    break;
                case 'C':
                    getal = 100;
                    break;
                case 'D':
                    getal = 500;
                    break;
                case 'M':
                    getal = 1000;
                    break;
                default:
                    getal = -1;
                    break;
            }

            Console.WriteLine($"Het Romeins getal {letter} komt overeen met het getal {getal}");
        }
    }
}
