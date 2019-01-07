using System;

namespace SyntraWestCSharpExercises.BuildingBlock6_IntroOOP.Opdracht06_01Kerstmis
{
    public class Opdracht06_01Kerstmis : ExerciseBase
    {
        public override void RunExercise()
        {
            Job maker = new Job("Maker", 21.60m);
            Job inpakker = new Job("Inpakker", 15.75m);

            Fee bert = new Fee("Einstein", "Bert", maker);
            Fee niels = new Fee("Bhor", "Niels", inpakker);

            Fabriek fabriek = new Fabriek(bert, niels, 5);

            Speelgoed[] speelgoed = fabriek.GetSpeelgoed();

            niels.MaakSpeelgoed(speelgoed[0], "teddy beer");
            niels.PakSpeelgoedIn(speelgoed[0]);
            Console.WriteLine();

            bert.PakSpeelgoedIn(speelgoed[0]);
            bert.MaakSpeelgoed(speelgoed[0], "teddy beer");
            bert.MaakSpeelgoed(speelgoed[0], "teddy beer");
            Console.WriteLine();

            niels.PakSpeelgoedIn(speelgoed[0]);
            niels.PakSpeelgoedIn(speelgoed[0]);
            Console.WriteLine();

            bert.MaakSpeelgoed(speelgoed[2], "Quantum Fysica voor baby's");
            Console.WriteLine();

            fabriek.PrintRaportFabriek();
        }
    }
}
