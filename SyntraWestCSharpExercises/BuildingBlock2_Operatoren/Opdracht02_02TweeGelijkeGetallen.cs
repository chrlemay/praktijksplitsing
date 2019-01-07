using System;

namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_02TweeGelijkeGetallen : ExerciseBase
    {
        public override void RunExercise()
        {
            int getal1, getal2;

            Console.WriteLine("Geef een eerste getal");
            getal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef een tweede getal");
            getal2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{getal1} en {getal2} zijn {(getal1 == getal2 ? "gelijk" : "verschillend")}");
        }
    }
}
