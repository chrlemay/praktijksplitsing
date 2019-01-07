using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_13BerekenenEvenGetallen : ExerciseBase
    {
        public override void RunExercise()
        {
            int getal = 0,
                even = 0,
                oneven = 0,
                somEven = 0,
                somOneven = 0;
            
            Console.WriteLine("Geef een aantal getallen in. (Afsluiten met een negatief getal)");
            getal = int.Parse(Console.ReadLine());

            do
            {
                if (getal % 2 == 0)
                {
                    even++;
                    somEven += getal;
                }
                else
                {
                    oneven++;
                    somOneven += getal;
                }

                getal = int.Parse(Console.ReadLine());
            }
            while (getal >= 0);

            Console.WriteLine($"Aantal even getallen: {even}\n" +
                $"Aantal oneven getallen: {oneven}\n" +
                $"Som van de even getallen: {somEven}\n" +
                $"Som van de oneven getallen: {somOneven}");

        }
    }
}
