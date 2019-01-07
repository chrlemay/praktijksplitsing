using System;

namespace SyntraWestCSharpExercises
{
    public class Opdracht03_02ZelfdeGetal : ExerciseBase
    {
        public override void RunExercise()
        {
            int getal1, getal2;
            string outputString;

            Console.WriteLine("Geef getal 1:");
            getal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef getal 2:");
            getal2 = int.Parse(Console.ReadLine());
            
            if(getal1 == getal2)
            {
                outputString = $"{getal1} en {getal2} zijn hetzelfde.";
            }
            else
            {
                outputString = $"{getal1} en {getal2} zijn niet hetzelfde.";
            }

            Console.WriteLine(outputString);
        }
    }
}
