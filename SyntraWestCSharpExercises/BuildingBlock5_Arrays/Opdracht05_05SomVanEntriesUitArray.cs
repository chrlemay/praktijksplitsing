using System;

namespace SyntraWestCSharpExercises.BuildingBlock5_Arrays
{
    public class Opdracht05_05SomVanEntriesUitArray : ExerciseBase
    {
        public override void RunExercise()
        {
            int[] getallen = new int[10];
            int som = 0;

            for (int i = 0; i < 10; i++)
            {
                getallen[i] = i + 1;
                som += getallen[i];
            }

            Console.WriteLine($"De som van de entries van de array is {som}");
        }
    }
}
