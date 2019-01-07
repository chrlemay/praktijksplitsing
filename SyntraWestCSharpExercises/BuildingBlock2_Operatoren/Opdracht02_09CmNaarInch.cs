using System;

namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_09CmNaarInch : ExerciseBase
    {
        const float cmPerInch = 2.54f;

        public override void RunExercise()
        {
            float inch, cm;

            Console.WriteLine("Geef lengte in cm in.");
            cm = float.Parse(Console.ReadLine());

            inch = cm / cmPerInch;

            Console.WriteLine($"{cm} cm is {inch} inch");
        }
    }
}
