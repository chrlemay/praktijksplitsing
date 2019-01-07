using System;

namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_14Scores : ExerciseBase
    {
        public override void RunExercise()
        {
            int score1 = 8;
            int score2 = 6;
            int score3 = 9;
            int score4 = 4;

            int som = score1 + score2 + score3 + score4;

            float gemiddelde = som / 4f;

            Console.WriteLine($"Het gemiddelde: {gemiddelde}.");
            Console.WriteLine($"Het som: {som}.");
        }
    }
}
