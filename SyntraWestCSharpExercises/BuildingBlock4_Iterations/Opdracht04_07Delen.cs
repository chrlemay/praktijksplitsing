using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_07Delen : ExerciseBase
    {
        public override void RunExercise()
        {
            int deeltal, deler, quotient = 0, rest, tussenDeeltal;

            Console.WriteLine("Geef deeltal/teller");
            deeltal = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef deler/noemer");
            deler = int.Parse(Console.ReadLine());

            tussenDeeltal = deeltal;

            while (deeltal >= deler)
            {
                deeltal = deeltal - deler;
                quotient += 1;
            }

            rest = deeltal;

            Console.WriteLine($"De bewerking {tussenDeeltal} / {deler}" +
                $"\nUitkomst = {quotient}" + 
                $"\nRest = {rest}");

        }
    }
}
