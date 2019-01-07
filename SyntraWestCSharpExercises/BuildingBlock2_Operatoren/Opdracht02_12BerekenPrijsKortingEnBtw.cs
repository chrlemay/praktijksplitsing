using System;

namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_12BerekenPrijsKortingEnBtw : ExerciseBase
    {
        public override void RunExercise()
        {
            decimal bedragExclBtw,
                    bedragInclBtw,
                    btwPercentage,
                    kortingsPercentage,
                    bedragBtw,
                    bedragKorting,
                    bedragExclKorting,
                    bedragInclKorting;

            Console.WriteLine("geef een bedrag Excl BTW");
            bedragExclBtw = decimal.Parse(Console.ReadLine());

            Console.WriteLine("geef een kortingspercentage");
            kortingsPercentage = decimal.Parse(Console.ReadLine());

            Console.WriteLine("geef een BTW percentage");
            btwPercentage = decimal.Parse(Console.ReadLine());

            bedragExclKorting = bedragExclBtw;

            bedragKorting = bedragExclKorting * (kortingsPercentage / 100);

            bedragInclKorting = bedragExclKorting - bedragKorting;

            bedragBtw = bedragInclKorting * (btwPercentage / 100);

            bedragInclBtw = bedragInclKorting + bedragBtw;

            Console.WriteLine($"Bedrag Exclusief BTW : {bedragExclBtw}");
            Console.WriteLine($"Bedrag Korting : {bedragKorting}");
            Console.WriteLine($"Bedrag met Korting : {bedragInclKorting}");
            Console.WriteLine($"Bedrag BTW : {bedragBtw}");
            Console.WriteLine($"Bedrag Inclusief BTW : {bedragInclBtw}");
        }
    }
}
