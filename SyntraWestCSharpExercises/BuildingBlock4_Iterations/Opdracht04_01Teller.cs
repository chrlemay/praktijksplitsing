using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_01Teller : ExerciseBase
    {
        public override void RunExercise()
        {
            int teller;

            Console.WriteLine("For");

            for (teller = 1; teller < 11; teller++)
            {
                Console.WriteLine($"teller = {teller}");
            }

            teller = 1;
            Console.WriteLine("\nWhile");

            while (teller < 11)
            {
                Console.WriteLine($"teller = {teller}");
                teller++;
            }

            teller = 1;
            Console.WriteLine("\nDo While");

            do
            {
                Console.WriteLine($"teller = {teller}");
                teller++;
            }
            while (teller < 11);

        }
    }
}
