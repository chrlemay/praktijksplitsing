using System;

namespace SyntraWestCSharpExercises.BuildingBlock5_Arrays
{
    public class Opdracht05_13WaardenGescheidenDoorKomma : ExerciseBase
    {
        public override void RunExercise()
        {
            int[] a = { 5, 3, 1, -1, -3 };
            
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);

                if (i != a.Length - 1)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
