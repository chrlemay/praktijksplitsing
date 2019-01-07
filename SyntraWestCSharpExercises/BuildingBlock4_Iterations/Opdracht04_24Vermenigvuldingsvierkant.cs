using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_24Vermenigvuldingsvierkant : ExerciseBase
    {
        public override void RunExercise()
        {
            Console.WriteLine("Geef een getal");
            int getal = int.Parse(Console.ReadLine());

            for (int i = 1; i <= getal; i++)
            {
                for (int j = 1; j <= getal; j++)
                {
                    Console.Write($"{i * j, 4}");
                }

                Console.WriteLine();
            }
        }
    }
}
