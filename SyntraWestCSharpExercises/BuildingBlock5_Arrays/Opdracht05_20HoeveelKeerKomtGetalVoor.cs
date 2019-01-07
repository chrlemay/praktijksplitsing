using System;

namespace SyntraWestCSharpExercises.BuildingBlock5_Arrays
{
    public class Opdracht05_20HoeveelKeerKomtGetalVoor : ExerciseBase
    {
        public override void RunExercise()
        {
            Random random = new Random();
            int[] voorkomen = new int[101];
            
            for (int i = 0; i < 10000; i++)
            {
                int randomgetal = random.Next(1, 101);
                Console.WriteLine($"Getal {i} = {randomgetal}, ");

                voorkomen[randomgetal]++;
            }

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Het getal {i} kwam {voorkomen[i]}\tkeer voor.");
            }
        }
    }
}
