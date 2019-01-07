using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_14OmzettenCijferResultatenNaarCodes : ExerciseBase
    {
        public override void RunExercise()
        {

            int ingaveGetal = 0;

            int totaal = 0;
            int tellerGraad = 0;
            int tellerGrO = 0;
            int tellerGO = 0;
            int tellerO = 0;
            int tellerV = 0;
            int tellerNG = 0;
            
            Console.WriteLine("Geef de resultaten in van de cursisten. " +
                "(stop door een groter getal dan 100 in te geven)");

            ingaveGetal = int.Parse(Console.ReadLine());

            while (ingaveGetal <= 100)
            {
                tellerGraad++;          // Tellen aantal getallen ingegeven
                totaal += ingaveGetal;  // Totaal

                if (ingaveGetal >= 85)
                {
                    tellerGrO++;
                }
                else if (ingaveGetal >= 77) // && ingaveGetal <= 84)
                {
                    tellerGO++;
                }  
                else if (ingaveGetal >= 68)// && ingaveGetal <= 76)
                {
                    tellerO++;
                }
                else if (ingaveGetal >= 50)// && ingaveGetal <= 67)
                {
                    tellerV++;
                }
                else
                {
                    tellerNG++;
                }

                ingaveGetal = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Aantal cursisten per graad.");
            Console.WriteLine($"Grootste onderscheiding: {tellerGrO}");
            Console.WriteLine($"Grote onderscheiding: {tellerGO}");
            Console.WriteLine($"Onderscheiding: {tellerO}");
            Console.WriteLine($"Voldoening: {tellerV}");
            Console.WriteLine($"Niet geslaagd: {tellerNG}");

        }
    }
}
