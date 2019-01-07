using System;
namespace SyntraWestCSharpExercises.BuildingBlock5_Arrays
{
    public class Opdracht05_19VerwijderenUitArray : ExerciseBase
    {
        public override void RunExercise()
        {
            string[] boerderijDieren = { "kip", "koe", "paard", "geit", "schaap" };
            int index;
            
            do
            {
                Console.WriteLine("Geef de positie waarop het dier moet verwijderd worden ");
                index = int.Parse(Console.ReadLine());

                if (index < 0 || index >= boerderijDieren.Length)
                {
                    Console.WriteLine("Ongeldige positie.");
                }
            }
            while (index < 0 || index >= boerderijDieren.Length);

            // Om een getal te verwijderen op een bepaalde positie, moet de getallen die
            // erna komen in het array een positie 'opschuiven naar links'. Dit opschuiven
            // bekomen we door die getallen te kopieren naar de vorige locatie in het array

            // Indien we als index 4 opgeven, doet de loop hieronder het volgende
            // array voordien :  a b c d e f g h
            //                            / / /
            // array nadien   :  a b c d f g h h

            for (int i = index; i < boerderijDieren.Length - 1; i++)
            {
                boerderijDieren[i] = boerderijDieren[i + 1];
            }

            // tot slot nog de tekst "LEEG" op de laatste positie plaatsen
            boerderijDieren[boerderijDieren.Length - 1] = "LEEG";

            for (int i = 0; i < boerderijDieren.Length; i++)
            {
                if (boerderijDieren[i] == "LEEG")
                {
                    break;
                }

                Console.WriteLine($"{boerderijDieren[i]} ");
            }
        }
    }
}
