using System;

namespace SyntraWestCSharpExercises.BuildingBlock5_Arrays
{
    public class Opdracht05_14ZoekWaardeInArray : ExerciseBase
    {
        public override void RunExercise()
        {
            int[] a = { 5, 3, 1, -1, -3, 3, 9, -4 };
            bool gevonden = false;

            Console.WriteLine("Geef het zoekgetal ");
            int zoekGetal = int.Parse(Console.ReadLine());

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == zoekGetal)
                {
                    if (!gevonden)
                    {
                        gevonden = true;
                        Console.WriteLine("Waarde gevonden op ");
                    }

                    Console.WriteLine($"{i} ");
                }
            }

            if (!gevonden)
            {
                Console.WriteLine("Waarde niet gevonden");
            }
        }
    }
}
