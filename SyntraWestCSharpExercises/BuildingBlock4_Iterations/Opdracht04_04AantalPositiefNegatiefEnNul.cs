using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_04AantalPositiefNegatiefEnNul : ExerciseBase
    {
        public override void RunExercise()
        {
            int aantalGetallen = 0;
            int getal = 0;
            int posGetal = 0;
            int negGetal = 0;
            int nulGetal = 0;

            Console.WriteLine("Hoeveel getallen wil je inlezen: ");
            aantalGetallen = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef getallen in gescheiden door enter: ");

            for (int i = 0; i < aantalGetallen; i++)
            {
                getal = int.Parse(Console.ReadLine());

                if (getal < 0)
                {
                    negGetal++;
                }
                else if (getal > 0)
                {
                    posGetal++;
                }
                else
                {
                    nulGetal++;
                }
            }

            Console.WriteLine($"Negatieve getallen = {negGetal}");
            Console.WriteLine($"Positieve getallen = {posGetal}");
            Console.WriteLine($"Nul getallen = {nulGetal}");
            Console.WriteLine();

        }
    }
}
