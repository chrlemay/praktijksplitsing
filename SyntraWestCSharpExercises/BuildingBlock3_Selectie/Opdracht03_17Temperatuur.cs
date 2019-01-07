using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_17Temperatuur : ExerciseBase
    {
        const float _absoluteNulpunt = -273.15f;

        public override void RunExercise()
        {
            float kelvin = 0;
            float celsius = 0;

            Console.WriteLine("Geef een temperatuur in Kelvin:");
            kelvin = float.Parse(Console.ReadLine());
            
            if (kelvin < 0)
            {
                Console.WriteLine("Foutieve invoer.  Het aantal graden Kelvin kan niet kleiner zijn dan 0.");
            }
            else
            {
                celsius = kelvin + _absoluteNulpunt;
                Console.WriteLine($"{kelvin} kelvin komt overeen met {celsius} graden Celsius.");
            }
        }
    }
}
