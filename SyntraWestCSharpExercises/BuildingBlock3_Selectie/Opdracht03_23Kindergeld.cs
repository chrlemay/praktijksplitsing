using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_23Kindergeld : ExerciseBase
    {
        public override void RunExercise()
        {
            int aantalKinderen = 0;
            float maandloon = 0;
            float kindergeld = 0;

            Console.WriteLine("Geef het aantal kinderen:");
            aantalKinderen = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef het maandloon:");
            maandloon = float.Parse(Console.ReadLine());

            kindergeld = aantalKinderen * 25;

            if (aantalKinderen > 2)
            {
                kindergeld += (aantalKinderen - 2) * 12.5f;

                if (aantalKinderen > 4)
                {
                    kindergeld += (aantalKinderen - 4) * 7.5f;
                }
            }

            if (maandloon <= 500)
            {
                kindergeld += kindergeld * 0.25f;
            }
            else
            {
                if (maandloon > 2000)
                {
                    kindergeld -= kindergeld * .25f;

                    if (kindergeld < (aantalKinderen * 25))
                    {
                        kindergeld = aantalKinderen * 25;
                    }
                }
            }

            Console.WriteLine($"Kindergeld={kindergeld}");
        }
    }
}
