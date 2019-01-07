using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_03GrootsteGetal : ExerciseBase
    {
        public override void RunExercise()
        {
            int getal1, getal2, getal3, grootsteGetal;

            Console.WriteLine("Geef getal 1:");
            getal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef getal 2:");
            getal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef getal 3:");
            getal3 = int.Parse(Console.ReadLine());

            if(getal1 > getal2)
            {
                grootsteGetal = getal1;
            }
            else
            {
                grootsteGetal = getal2;
            }

            if(grootsteGetal < getal3)
            {
                grootsteGetal = getal3;
            }

            Console.WriteLine($"Het grooste getal tussen {getal1}, {getal2} en {getal3} is {grootsteGetal}");
        }
    }
}
