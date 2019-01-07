using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_21EenvoudigeSortering : ExerciseBase
    {
        public override void RunExercise()
        {
            int getal1 = 0;
            int getal2 = 0;
            int getal3 = 0;
            int temp;
            
            Console.WriteLine("Geef getal1 in");
            getal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef getal2 in");
            getal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef getal3 in");
            getal3 = int.Parse(Console.ReadLine());


            if (getal1 > getal2)
            {
                temp = getal1;
                getal1 = getal2;
                getal2 = temp;
            }

            if (getal2 > getal3)
            {
                temp = getal2;
                getal2 = getal3;
                getal3 = temp;
            }

            if (getal1 > getal2)
            {
                temp = getal1;
                getal1 = getal2;
                getal2 = temp;
            }

            Console.WriteLine($"{getal1} {getal2} {getal3}");
        }
    }
}
