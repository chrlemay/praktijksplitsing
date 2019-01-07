using System;
namespace SyntraWestCSharpExercises.BuildingBlock5_Arrays
{
    public class Opdracht05_11Zoeken : ExerciseBase
    {
        public override void RunExercise()
        {
            int aantal = 20;
            Random random = new Random();

            int[] getallenreeks = new int[aantal];
            int teZoekGetal = 0;                    
            bool gevonden = false;              
            
            for (int i = 0; i < aantal; i++)
            {
                getallenreeks[i] = random.Next(0, 31);
            }

            Console.WriteLine("Welk getal wil je zoeken");
            teZoekGetal = int.Parse(Console.ReadLine());

            // Print array
            for (int i = 0; i < aantal; i++)
            {
                Console.Write($"{getallenreeks[i]} ");
            }

            Console.WriteLine();

            // Zoeken naar het getal
            int positie = 0;

            for (int i = 0; !gevonden && i < aantal; i++)      // zolang getal niet gevonden én we hebben nog getallen in de array
            {
                if (getallenreeks[i] == teZoekGetal)      // getal gevonden
                {
                    positie = i;                     // welke positie
                    gevonden = true;                 // flag verplaatsen   
                }
            }

            // Output
            if (gevonden)
            {
                Console.WriteLine($"Het getal {teZoekGetal} is gevonden op positie: {positie}");
            }
            else
            {
                Console.WriteLine($"Het getal {teZoekGetal} is niet gevonden");
            }
        }
    }
}
