using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_29Lidgeld : ExerciseBase
    {
        public override void RunExercise()
        {
            string naam = "";
            int leeftijd = 0;
            int kinderen = 0;
            decimal inkomen = 0;
            decimal lidgeld = 0;
            decimal korting = 0;
            
            do
            {
                lidgeld = 10;
                korting = 0;

                Console.WriteLine("Geef naam:");
                naam = Console.ReadLine();

                if (naam.ToUpper() == "STOP")
                {
                    return;
                }

                Console.WriteLine("Geef leeftijd:");
                leeftijd = int.Parse(Console.ReadLine());

                Console.WriteLine("Geef aantal kinderen:");
                kinderen = int.Parse(Console.ReadLine());

                Console.WriteLine("Geef inkomen:");
                inkomen = decimal.Parse(Console.ReadLine());

                if (leeftijd > 50)
                {
                    korting = 2;
                    Console.WriteLine($"Korting leeftijd: {korting}");
                }

                korting += kinderen > 5 ? 5 : kinderen;
                Console.WriteLine($"Korting kinderen: {korting}");

                if (inkomen < 12500)
                {
                    korting += (decimal)2.5;
                    Console.WriteLine($"Korting inkomen: {korting}");
                }

                if (korting > (decimal)8.5)
                {
                    korting = (decimal)8.5;
                }

                lidgeld -= korting;
                Console.WriteLine($"Korting totaal: {korting}");

                Console.WriteLine($"{naam} moet {lidgeld} betalen");
                

            }
            while (true);
        }
    }
}
