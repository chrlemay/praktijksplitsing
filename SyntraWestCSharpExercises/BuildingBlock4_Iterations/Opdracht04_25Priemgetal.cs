using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_25Priemgetal : ExerciseBase
    {
        public override void RunExercise()
        {
            bool isPriemgetal;

            Console.WriteLine("Geef een getal");
            int getal = int.Parse(Console.ReadLine());

            for (int i = 2; i <= getal; i++)
            {
                isPriemgetal = true;

                for (int k = 2; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        isPriemgetal = false;
                        break;
                    }
                }

                if (!isPriemgetal)
                {
                    continue;
                }

                Console.WriteLine($"{i}");
            }
        }
    }
}
