using System;

namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_16EvenOfOneven : ExerciseBase
    {
        public override void RunExercise()
        {
            int getal;

            Console.WriteLine("geef een getal:");
            getal = int.Parse(Console.ReadLine());

            Console.WriteLine($"{getal} is {(getal % 2 == 0 ? "even" : "oneven")}");
        }
    }
}
