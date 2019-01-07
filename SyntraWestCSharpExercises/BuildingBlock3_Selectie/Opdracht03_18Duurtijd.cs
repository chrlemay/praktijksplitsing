using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_18Duurtijd : ExerciseBase
    {
        public override void RunExercise()
        {
            int eindMin = 0;
            int eindUur = 0;
            int beginMin = 0;
            int beginUur = 0;
            int duurMin = 0;
            int duurUur = 0;

            Console.WriteLine("Geef BeginUur:");
            beginUur = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef BeginMinuten:");
            beginMin = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef DuurUur:");
            duurUur = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef DuurMinuten,:");
            duurMin = int.Parse(Console.ReadLine());


            eindMin = beginMin + duurMin;
            eindUur = beginUur + duurUur;

            if (eindMin >= 60)
            {
                eindUur += eindMin / 60;
                eindMin %= 60;
            }

            Console.WriteLine($"EindTijd : {eindUur}:{eindMin}");
        }
    }
}
