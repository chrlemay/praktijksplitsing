using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_01AbsoluteWaarde : ExerciseBase
    {
        public override void RunExercise()
        {
            int waarde, absoluteWaarde;

            Console.WriteLine("Geef een Waarde");
            waarde = int.Parse(Console.ReadLine());

            absoluteWaarde = waarde;

            if(waarde < 0)
            {
                absoluteWaarde = waarde * -1;
            }

            Console.WriteLine($"De absolute waarde van {waarde} is {absoluteWaarde}");
        }
    }
}
