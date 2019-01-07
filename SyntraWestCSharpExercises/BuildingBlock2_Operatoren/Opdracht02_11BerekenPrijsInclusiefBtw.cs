using System;

namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_11BerekenPrijsInclusiefBtw : ExerciseBase
    {
        public override void RunExercise()
        {
            decimal bedragExclBtw, bedragInclBtw, btwPercentage;

            // Berekenen inclusief

            Console.WriteLine("Geef prijs Excl. BTW");
            bedragExclBtw = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Geef BTW percentage");
            btwPercentage = decimal.Parse(Console.ReadLine());

            bedragInclBtw = bedragExclBtw * (100 + btwPercentage) / 100;

            Console.WriteLine($"Excl BTW : {bedragExclBtw}. Incl BTW : {bedragInclBtw}");
            Console.WriteLine();

            // Berekenen Exclusief

            Console.WriteLine("Geef prijs Incl. BTW");
            bedragInclBtw = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Geef BTW percentage");
            btwPercentage = decimal.Parse(Console.ReadLine());

            bedragExclBtw = bedragInclBtw * 100 / (100 + btwPercentage);

            Console.WriteLine($"Excl BTW : {bedragExclBtw}. Incl BTW : {bedragInclBtw}");
        }
    }
}
