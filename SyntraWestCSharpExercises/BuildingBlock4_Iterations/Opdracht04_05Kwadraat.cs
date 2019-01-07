using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_05Kwadraat : ExerciseBase
    {
        public override void RunExercise()
        {
            int teller = 1;
            int kwadraat = 0;

            while (teller < 21)
            {
                kwadraat = teller * teller;
                Console.WriteLine($"kwadraat van {teller} = {kwadraat}");

                teller++;
            }
        }
    }
}
