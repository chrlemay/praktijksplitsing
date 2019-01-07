using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_09HalveKerstboom : ExerciseBase
    {
        public override void RunExercise()
        {
            for(int rij = 0; rij < 5; rij++)
            {
                for(int kolom = 0; kolom <= rij; kolom++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
