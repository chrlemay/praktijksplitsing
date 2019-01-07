using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_18Uurwerk : ExerciseBase
    {
        public override void RunExercise()
        {
            for (int uren = 0; uren < 2; uren++)
            {
                for (int min = 0; min < 60; min++)
                {
                    for (int sec = 0; sec < 60; sec++)
                    {
                        Console.WriteLine($"tijd: {uren}:{min}:{sec}");
                    }
                }
            }

        }
    }
}
