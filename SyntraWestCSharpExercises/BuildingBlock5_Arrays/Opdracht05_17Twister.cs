using System;

namespace SyntraWestCSharpExercises.BuildingBlock5_Arrays
{
    public class Opdracht05_17Twister : ExerciseBase
    {
        public override void RunExercise()
        {
            Random random = new Random();

            string[] lichaamsDelen = { "linkervoet", "rechterhand", "linkervoet", "rechtervoet" };
            string[] kleuren = { "groen", "rood", "geel", "blauw" };

            
            for (int i = 0; i < 10; i++)
            {
                int x = random.Next(lichaamsDelen.Length);
                string lichaamsDeel = lichaamsDelen[x];

                x = random.Next(kleuren.Length);
                string kleur = kleuren[x];

                Console.WriteLine($"{lichaamsDeel} op {kleur}");
            }
        }
    }
}
