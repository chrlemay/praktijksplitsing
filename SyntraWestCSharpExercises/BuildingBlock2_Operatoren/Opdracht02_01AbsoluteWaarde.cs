using System;

namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_01AbsoluteWaarde : ExerciseBase
    {
        public override void RunExercise()
        {
            short getal;
            short absolutGetal;

            Console.WriteLine("Geef een getal in (positief of negatief)");
            getal = short.Parse(Console.ReadLine());

            absolutGetal = getal < 0 ? (short)(getal * -1) : getal;

            Console.WriteLine($"De absolute waarde van {getal} is {absolutGetal}");
        }
    }
}
