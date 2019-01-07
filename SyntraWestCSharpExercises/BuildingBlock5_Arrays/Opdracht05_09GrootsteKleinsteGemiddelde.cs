using System;

namespace SyntraWestCSharpExercises.BuildingBlock5_Arrays
{
    public class Opdracht05_09GrootsteKleinsteGemiddelde : ExerciseBase
    {
        public override void RunExercise()
        {
            float[] getallen = new float[10];
            float som = 0, 
                grootsteGetal = int.MinValue, 
                kleinsteGetal = int.MaxValue;
            float gemiddelde;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Geef een getal voor entry {i}");
                getallen[i] = float.Parse(Console.ReadLine());

                som += getallen[i];

                if(getallen[i] < kleinsteGetal)
                {
                    kleinsteGetal = getallen[i];
                }

                if(getallen[i] > grootsteGetal)
                {
                    grootsteGetal = getallen[i];
                }
            }

            gemiddelde = som / 10f;

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{getallen[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine($"Grootste getal = {grootsteGetal:N2}");
            Console.WriteLine($"Kleinste getal = {kleinsteGetal:N2}");
            Console.WriteLine($"gemiddelde = {gemiddelde:N2}");
        }
    }
}
