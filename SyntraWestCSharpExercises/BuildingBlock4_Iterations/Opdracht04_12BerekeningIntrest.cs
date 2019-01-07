using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_12BerekeningIntrest : ExerciseBase
    {
        public override void RunExercise()
        {
            decimal geld = 0;
            decimal startwaarde = 1000;
            float intrest = 0.05f;
            decimal intrestJaar = 0;
            
            for (int jaar = 1; jaar <= 10; jaar++)
            {
                intrestJaar = (decimal)Math.Pow(1.0 + intrest, jaar);

                geld = startwaarde * intrestJaar;

                Console.WriteLine($"Jaar {jaar}: Intrest: {(intrestJaar - 1) * 1000:N2} " +
                    $"Bedrag op bank: {geld:N2}");
            }
        }
    }
}
