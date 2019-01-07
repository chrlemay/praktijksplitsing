using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_19Factuur : ExerciseBase
    {
        public override void RunExercise()
        {
            float eindBedrag = 0;
            float korting = 0;

            Console.WriteLine("Geef eindbedrag in");
            eindBedrag = float.Parse(Console.ReadLine());
        
            if (eindBedrag > 5000)
            {
                korting = (float)(eindBedrag * 0.03);
            }

            Console.WriteLine($"Te betalen : {eindBedrag - korting}");
        }
    }
}
