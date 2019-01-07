using System;

namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_19GewichtVoorConstructie : ExerciseBase
    {
        public override void RunExercise()
        {
            float b, h, l, g;

            Console.WriteLine("Geef breedte:");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Geef hoogte:");
            h = float.Parse(Console.ReadLine());

            Console.WriteLine("Geef lengte:");
            l = float.Parse(Console.ReadLine());

            g = 19 * b * h * h / l;

            Console.WriteLine("Het maximale gewicht voor de stalen balk met:");
            Console.WriteLine($"\tbreedte {b}");
            Console.WriteLine($"\thoogte {h}");
            Console.WriteLine($"\tlengte {l}");
            Console.WriteLine($"is {g} kg");
        }
    }
}
