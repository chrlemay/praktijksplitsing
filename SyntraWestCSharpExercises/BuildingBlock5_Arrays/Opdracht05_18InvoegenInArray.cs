using System;

namespace SyntraWestCSharpExercises.BuildingBlock5_Arrays
{
    public class Opdracht05_18InvoegenInArray : ExerciseBase
    {
        public override void RunExercise()
        {
            int[] a = { 5, 3, 1, -1, -3, 7, 9, 10, 23 };
            int index;

            Console.WriteLine("Geef een getal ");
            int getal = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Geef de positie waarop het getal moet ingelast worden ");
                index = int.Parse(Console.ReadLine());

                if (index < 0 || index >= a.Length)
                {
                    Console.WriteLine("Ongeldige positie.");
                }
            }
            while (index < 0 || index >= a.Length);

            // Om een getal in te lassen op een bepaalde positie, moet de getallen die
            // erna komen in het array een positie 'doorschuiven'. Dit doorschuiven
            // bekomen we door die getallen te kopieren naar de volgende locatie in het array

            // We gaan de getallen kopieren van achter naar voren, anders wordt het nogal
            // omslachtig om te vermijden dat we een array element overschrijven dat we
            // laten nog nodig hebben
            //
            // Indien we als index 4 opgeven, doet de loop hieronder het volgende
            // positie:      0  1  2  3  4  5  6  7
            // a voordien :  5  3  1 -1 -3  0 10 23
            //                            \  \  \
            //                             \  \  \
            // a nadien   :  5  3  1 -1 -4 -3  0 10

            // Opschuiven
            for (int i = a.Length - 1; i > index; i--)
            {
                a[i] = a[i - 1];
            }

            // tot slot nog het nieuwe getal op de juiste positie plaatsen
            a[index] = getal;

            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]} ");
            }
        }
    }
}
