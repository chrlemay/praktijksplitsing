using System;
namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_17Kwadraat : ExerciseBase
    {
        public override void RunExercise()
        {
            Console.WriteLine("Geef een getal in:");
            int getal = int.Parse(Console.ReadLine());

            Console.WriteLine($"Het kwadraat van {getal} is {getal * getal}");
        }
    }
}
