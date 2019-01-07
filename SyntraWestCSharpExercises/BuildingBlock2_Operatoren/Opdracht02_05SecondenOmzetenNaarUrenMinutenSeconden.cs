using System;

namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_05SecondenOmzetenNaarUrenMinutenSeconden : ExerciseBase
    {
        public override void RunExercise()
        {
            int tijdInSeconden;
            int uren, minuten, seconden;

            Console.WriteLine("Geef een aantal seconen in:");
            tijdInSeconden = int.Parse(Console.ReadLine());

            uren = tijdInSeconden / 3600;
            tijdInSeconden %= 3600; // <=> tijdInSeconden -= uren * 3600;

            // tijdInSeconden is nu kleiner dan 3600
            minuten = tijdInSeconden / 60;
            tijdInSeconden %= 60; // <=> tijdInSeconden -= minuten * 60;

            // tijdInSeconden is nu kleiner dan 60
            seconden = tijdInSeconden;

            Console.WriteLine($"U:{uren} M:{minuten} S:{seconden}");
        }
    }
}
