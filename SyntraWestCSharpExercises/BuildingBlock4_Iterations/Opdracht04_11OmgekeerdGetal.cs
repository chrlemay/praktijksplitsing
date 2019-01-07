using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_11OmgekeerdGetal : ExerciseBase
    {
        public override void RunExercise()
        {
            int getal = 0;              // originele getal
            int digit = 0;              // laatste digit van het getal
            int copyGetal = 0;         // kopie van het originele getal
            int omgekeerdGetal = 0;     // het omgekeerde getal
            
            // Invoer van de gebruiker
            Console.WriteLine("Geef een getal in: ");
            getal = int.Parse(Console.ReadLine());

            copyGetal = getal;  // op het einde willen we nog het originele getal op het scherm plaatsen

            // Berekening van het omgekeerde getal
            while (copyGetal > 0)            // Zolang er digits zijn
            {
                digit = copyGetal % 10;    // Laatste digit uit het getal halen
                copyGetal /= 10;        // Berekenen van het nieuwe getal zonder de laatste digit
                omgekeerdGetal = omgekeerdGetal * 10 + digit; // Het omgekeerde getal digit per digit herconstrueren. 
            }

            // Uitvoer
            Console.WriteLine($"Het originele getal is: {getal}");
            Console.WriteLine($"Het omgekeerde getal is: {omgekeerdGetal}");
            Console.WriteLine();

        }
    }
}
