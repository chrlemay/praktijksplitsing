using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_20Deling : ExerciseBase
    {
        public override void RunExercise()
        {
            int getal1 = 0;
            int getal2 = 0;
            int grootste;
            int kleinste;

            Console.WriteLine("Geef getal1 in");
            getal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef getal2 in");
            getal2 = int.Parse(Console.ReadLine());

            if (getal1 > getal2)
            {
                grootste = getal1;
                kleinste = getal2;
            }
            else
            {
                grootste = getal2;
                kleinste = getal1;
            }

            if (kleinste == 0)
            {
                Console.WriteLine("Geen correcte invoer.  Kan niet delen door 0.");
            }
            else
            {
                Console.WriteLine($"Resultaat : {(float)grootste / kleinste}");
            }
        }
    }
}
