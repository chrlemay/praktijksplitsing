using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_15HogerLager : ExerciseBase
    {
        public override void RunExercise()
        {
            Random randomGetalGenerator = new Random();

            int randomGetal = randomGetalGenerator.Next(1,11);
            int getal, aantalBeruten = 0;
            bool gevonden = false;
            string feedback = string.Empty;

            do
            {
                aantalBeruten++;                          
                
                Console.WriteLine("Geef een getal in:");
                getal = int.Parse(Console.ReadLine());

                if (getal == randomGetal)
                {
                    feedback = $"Je hebt het getal {getal} geraden in {aantalBeruten} beurten ";
                    gevonden = !gevonden; 
                }
                else if (getal < randomGetal)
                {
                    feedback = "Het getal dat we zoeken is hoger";
                }
                else
                {
                    feedback = "Het getal dat we zoeken is lager";
                }

                Console.WriteLine(feedback);
            }
            while (!gevonden);
        }
    }
}
