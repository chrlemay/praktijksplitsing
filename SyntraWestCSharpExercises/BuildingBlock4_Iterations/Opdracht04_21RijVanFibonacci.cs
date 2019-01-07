using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_21RijVanFibonacci : ExerciseBase
    {
        public override void RunExercise()
        {
            long getal = 1;
            long vorigGetal = 0;
            long som = 0;

            Console.WriteLine(vorigGetal);
            Console.WriteLine(getal);

            for (int i = 1; i <= 13; i++)
            {
                som = getal + vorigGetal;
                
                vorigGetal = getal;
                getal = som;

                Console.Write($", {som}");
            }
        }
    }
}
