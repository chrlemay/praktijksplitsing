using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_23TafelVanVermenigvuldigen : ExerciseBase
    {
        public override void RunExercise()
        {
            int getal;

            Console.WriteLine("Geef een getal");
            getal = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} * {getal} = {i * getal}");
            }
        }
    }
}
