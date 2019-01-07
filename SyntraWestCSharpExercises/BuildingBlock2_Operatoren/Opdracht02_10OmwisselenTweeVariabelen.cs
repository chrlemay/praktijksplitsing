using System;

namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_10OmwisselenTweeVariabelen : ExerciseBase
    {
        public override void RunExercise()
        {
            int getal1, getal2, tussengetal;

            Console.WriteLine("Geef getal 1 in:");
            getal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef getal 2 in:");
            getal2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Voor omwisseleing: getal1 = {getal1} - getal2 = {getal2}");

            tussengetal = getal1;
            getal1 = getal2;
            getal2 = tussengetal;

            Console.WriteLine($"Na omwisseleing: getal1 = {getal1} - getal2 = {getal2}");
        }
    }
}
