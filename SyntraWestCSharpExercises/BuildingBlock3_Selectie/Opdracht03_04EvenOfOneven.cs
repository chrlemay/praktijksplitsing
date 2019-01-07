using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_04EvenOfOneven : ExerciseBase
    {
        public override void RunExercise()
        {
            int getal;

            Console.WriteLine("Geef een getal:");
            getal = int.Parse(Console.ReadLine());

            if(getal % 2 == 0)
            {
                Console.WriteLine($"{getal} is even.");
            }
            else
            {
                Console.WriteLine($"{getal} is oneven.");
            }
        }
    }
}
