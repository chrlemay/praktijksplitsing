using System;

namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_13BtwValidatie : ExerciseBase
    {
        public override void RunExercise()
        {
            long btwNummer;
            long deeltal;
            byte rest;
            byte controle;

            Console.WriteLine("Geef een btw nummer in.");
            btwNummer = long.Parse(Console.ReadLine());

            deeltal = btwNummer / 100;
            controle = (byte)(btwNummer % 100);

            rest = (byte)(deeltal % 97);

            Console.WriteLine($"Het btw nummer is {(controle == 97 - rest ? "geldig" : "ongeldig")}");
        }
    }
}
