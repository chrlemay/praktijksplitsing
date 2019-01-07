using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_22Ratten : ExerciseBase
    {
        public override void RunExercise()
        {
            double aantal = 2;
            float groei = 0.05f;
            int jaar = 0;
            
            while (aantal <= 10)
            {
                aantal *= 1 + groei;
                jaar++;
            }

            Console.WriteLine($"Binnen {jaar} jaar zijn er in New York 10 miljoen ratten");
        }
    }
}
