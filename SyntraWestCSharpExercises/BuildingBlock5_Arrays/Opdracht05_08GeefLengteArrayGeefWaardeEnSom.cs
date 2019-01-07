using System;

namespace SyntraWestCSharpExercises.BuildingBlock5_Arrays
{
    public class Opdracht05_08GeefLengteArrayGeefWaardeEnSom : ExerciseBase
    {
        public override void RunExercise()
        {
            Console.WriteLine("Hoe groot moet de array zijn?");
            int arrayLength = int.Parse(Console.ReadLine()) + 1;

            int[] getallen = new int[arrayLength];

            for (int i = 0; i < arrayLength - 1; i++)
            {
                Console.WriteLine($"Geef een getal voor entry {i}");
                getallen[i] = int.Parse(Console.ReadLine());
                
                getallen[arrayLength - 1] += getallen[i];
            }

            Console.WriteLine();

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(getallen[i]);
            }
        }
    }
}
