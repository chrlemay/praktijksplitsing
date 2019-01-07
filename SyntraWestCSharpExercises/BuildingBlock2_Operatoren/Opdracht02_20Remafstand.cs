using System;

namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_20Remafstand : ExerciseBase
    {
        public override void RunExercise()
        {
            float snelheid, remafstandDroog, remafstandNat;

            Console.WriteLine("Geef de snelheid in:");
            snelheid = float.Parse(Console.ReadLine());

            remafstandDroog = (float)Math.Pow(snelheid / 10, 2) / 2;

            remafstandNat = (float)Math.Pow(snelheid / 10, 2) / 2 * 1.5f;

            Console.WriteLine($"de remafstand bij droog weer is {remafstandDroog} meter.");
            Console.WriteLine($"de remafstand bij nat weer is {remafstandNat} meter.");
        }
    }
}
