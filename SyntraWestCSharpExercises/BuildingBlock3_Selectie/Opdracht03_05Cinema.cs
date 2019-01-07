using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_05Cinema : ExerciseBase
    {
        public override void RunExercise()
        {
            int leeftijd;
            float teBetalen, kortingsPercentage = 0;

            Console.WriteLine("Geef een leeftijd in:");
            leeftijd = int.Parse(Console.ReadLine());

            if (leeftijd < 11)
            {
                teBetalen = 1;
            }
            else
            {
                teBetalen = 3;

                if (leeftijd < 15)
                {
                    kortingsPercentage = 15;
                }
                else if (leeftijd < 18)
                {
                    kortingsPercentage = 10;
                }
                else if (leeftijd < 21)
                {
                    kortingsPercentage = 5;
                }
                else
                {
                    kortingsPercentage = 0;
                }
            }

            teBetalen -= teBetalen * kortingsPercentage / 100;

            Console.WriteLine($"Een leeftijd van {leeftijd} jaar krijgt een korting van {kortingsPercentage}% en betaalt {teBetalen} euro.");
        }
    }
}
