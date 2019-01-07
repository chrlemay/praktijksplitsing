using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_03GrootsteGetal : ExerciseBase
    {
        public override void RunExercise()
        {
            int aantalGetallen = 0;
            int getal = 0;
            int grootsteGetal = 0;

            Console.WriteLine("Hoeveel getallen wil je ingeven: ");
            aantalGetallen = int.Parse(Console.ReadLine());

            for (int i = 0; i < aantalGetallen; i++)
            {
                Console.WriteLine($"Geef getal {i+1} in: ");
                getal = int.Parse(Console.ReadLine());
                
                if (getal > grootsteGetal)
                {
                    grootsteGetal = getal;
                }

                //grootsteGetal = getal > grootsteGetal ? getal : grootsteGetal;
            }

            Console.WriteLine($"Grootste getal = {grootsteGetal}");
            Console.WriteLine();

        }
    }
}
