using System;

namespace SyntraWestCSharpExercises.BuildingBlock5_Arrays
{
    public class Opdracht05_06GeefLengteVanArray : ExerciseBase
    {
        public override void RunExercise()
        {
            Console.WriteLine("Hoe groot moet de array zijn?");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] getallen = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                getallen[i] = i + 1;
            }

            Console.WriteLine();

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(getallen[i]);
            }
        }
    }
}
