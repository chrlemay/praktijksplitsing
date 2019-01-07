using System;

namespace SyntraWestCSharpExercises.BuildingBlock5_Arrays
{
    public class Opdracht05_02Eerste10EvenGetallen : ExerciseBase
    {
        public override void RunExercise()
        {
            int[] getallen = new int[10];

            for (int i = 0, j = 2; i < 10; i++, j += 2)
            {
                getallen[i] = j;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(getallen[i]);
            }
        }
    }
}
