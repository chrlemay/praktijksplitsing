using System;

namespace SyntraWestCSharpExercises.BuildingBlock5_Arrays
{
    public class Opdracht05_16PuntenVoorEenVak : ExerciseBase
    {
        public override void RunExercise()
        {
            string[] vakken = { "Frans", "Engels", "Wiskunde", "Duits", "L.O." };
            int[] scores = { 34, 55, 20, 10, 80 };
            
            for (int i = 0; i < scores.Length; i++)
            {
                int score = scores[i];

                if (score < 50)
                {
                    string vak = vakken[i];
                    Console.WriteLine(vak);
                }
            }
        }
    }
}
