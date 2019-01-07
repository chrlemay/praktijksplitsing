using System;

namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_07DagenTotNieuwJaar : ExerciseBase
    {
        public override void RunExercise()
        {
            int datum;
            int dd;
            int mm;
            int jjjj;
            int dagen;

            Console.WriteLine("Geef een datum in (ddmmjjjj)");
            datum = int.Parse(Console.ReadLine());

            dd = datum / 1000000;
            datum %= 1000000;

            mm = datum / 10000;
            datum %= 10000;

            jjjj = datum;

            dagen = (12 - mm) * 30 + (30 - dd);

            Console.WriteLine($"Het duurt nog {dagen} dagen voordat het nieuwjaar is.");
        }
    }
}
