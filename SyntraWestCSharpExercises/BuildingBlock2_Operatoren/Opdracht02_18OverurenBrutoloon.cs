using System;

namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_18OverurenBrutoloon : ExerciseBase
    {
        public override void RunExercise()
        {
            float uurloon, uren, overuren;

            Console.WriteLine("geef Uurlon :");
            uurloon = float.Parse(Console.ReadLine());

            Console.WriteLine("geef aantal uren :");
            uren = float.Parse(Console.ReadLine());

            Console.WriteLine("geef aantal overuren :");
            overuren = float.Parse(Console.ReadLine());

            Console.WriteLine($"Het loon bedraagt {(uren + overuren * 1.5) * uurloon:N2}");
        }
    }
}
