using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_08Faculteit : ExerciseBase
    {
        public override void RunExercise()
        {
            int getal, copyGetal;
            long faculteit = 1;

            Console.WriteLine("Van welk getal wil je de faculteit berekenen?");
            getal = copyGetal = int.Parse(Console.ReadLine());

            if(getal < 0)
            {
                Console.WriteLine("Faculteit van een negatief getal bestaat niet.");
                return;
            }

            if(getal == 0)
            {
                getal = 1;
            }

            while(getal > 1)
            {
                faculteit *= getal;
                getal--;
            }

            Console.WriteLine($"Faculteit van {copyGetal} is {faculteit}");
        }
    }
}
