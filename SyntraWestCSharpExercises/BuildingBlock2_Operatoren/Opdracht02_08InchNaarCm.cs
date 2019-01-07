using System;

namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_08InchNaarCm : ExerciseBase
    {
        const float cmPerInch = 2.54f;

        public override void RunExercise()
        {
            float inch, cm;

            Console.WriteLine("Geef lengte in Inch in.");
            inch = float.Parse(Console.ReadLine());

            cm = inch * cmPerInch;

            Console.WriteLine($"{inch} inch is {cm} cm");
        }
    }
}
