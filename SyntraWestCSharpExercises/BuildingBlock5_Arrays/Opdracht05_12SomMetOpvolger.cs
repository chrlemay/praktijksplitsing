using System;

namespace SyntraWestCSharpExercises.BuildingBlock5_Arrays
{
    public class Opdracht05_12SomMetOpvolger : ExerciseBase
    {
        public override void RunExercise()
        {
            int[] a = { 5, 3, 1, -1, -3 };
            
            for (int i = 0; i < a.Length - 1; i++)
            {
                a[i] = a[i] + a[i + 1];
                Console.WriteLine(a[i]);
            }
            
            Console.WriteLine(a[a.Length - 1]);
        }
    }
}
