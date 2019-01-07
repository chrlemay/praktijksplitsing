using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_10Gemiddelde : ExerciseBase
    {
        public override void RunExercise()
        {
            int startWaarde = 5;
            int eindWaarde = 10;
            int som = 0;
            int aantal = 0;
            float gemiddelde;

            for (int i = startWaarde + 1; i < eindWaarde; i++)
            {
                Console.WriteLine(i);
                som += i;
                aantal++;
            }

            gemiddelde = (float)som / aantal;
            Console.WriteLine($"Het gemiddelde van de getallen tussen {startWaarde} en {eindWaarde} is:" +
                $" {gemiddelde}");
        }
    }
}
