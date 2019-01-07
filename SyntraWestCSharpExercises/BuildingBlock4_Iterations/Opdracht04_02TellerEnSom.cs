using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_02TellerEnSom : ExerciseBase
    {
        public override void RunExercise()
        {
            int teller;
            int som = 0;

            for (teller = 20; teller < 31; teller++)
            {
                Console.WriteLine($"teller = {teller}");
                som += teller;
            }

            Console.WriteLine($"Totaal = {som}");
        }
    }
}
