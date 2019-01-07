using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_20Priemgetallen : ExerciseBase
    {
        public override void RunExercise()
        {
            int getal;
            bool isPriemGetal = true;
            
            Console.WriteLine("Geef een getal");
            getal = int.Parse(Console.ReadLine());
            
            for (int deler = 2; deler < getal; deler++)
            {
                if (getal % deler == 0)
                {
                    isPriemGetal = false;
                    break;
                }
            }

           Console.WriteLine($"{getal} is {(isPriemGetal ? "een" : "geen")} priemgetal.");
        }
    }
}
