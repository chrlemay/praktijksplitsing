using System;

namespace SyntraWestCSharpExercises.BuildingBlock5_Arrays
{
    public class Opdracht05_01StopWaardenInArray : ExerciseBase
    {
        public override void RunExercise()
        {
            int[] getallen = new int[10];

            for(int i = 0; i < 10; i++)
            {
                getallen[i] = i + 1;
            }

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(getallen[i]);
            }
        }
    }
}
