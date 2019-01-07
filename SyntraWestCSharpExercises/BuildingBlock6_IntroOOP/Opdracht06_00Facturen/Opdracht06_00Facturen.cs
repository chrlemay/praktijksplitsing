using System;

namespace SyntraWestCSharpExercises.BuildingBlock6_IntroOOP.Opdracht06_00Facturen
{
    public class Opdracht06_00Facturen : ExerciseBase
    {
        public override void RunExercise()
        {
            Btw btw12 = new Btw(12);
            Btw btw21 = new Btw(21);

            Bedrijf yoloo = new Bedrijf("Yoloo", true, 200); // Mijnbedrijf
            Bedrijf mikadoo = new Bedrijf("Mikadoo", false, 0);
            Bedrijf ponchoo = new Bedrijf("Ponchoo", false, 0);
            
            yoloo.BetaalFactuur(0);
            mikadoo.BetaalFactuur(0);
            Console.WriteLine();

            yoloo.StelFacuurOp(0, yoloo, btw12, 50);
            mikadoo.StelFacuurOp(0, yoloo, btw12, 50);
            Console.WriteLine();

            yoloo.StelFacuurOp(0, mikadoo, btw12, 50);
            yoloo.StelFacuurOp(0, mikadoo, btw12, 50);
            Console.WriteLine();

            yoloo.BetaalFactuur(0);
            yoloo.StelFacuurOp(1, ponchoo, btw21, 50);
            Console.WriteLine();

            yoloo.StelFacuurOp(2, mikadoo, btw21, 150);
            yoloo.BetaalFactuur(2);
            Console.WriteLine();

            mikadoo.PrintRapport();
            Console.WriteLine();
            yoloo.PrintRapport();
        }
    }
}
