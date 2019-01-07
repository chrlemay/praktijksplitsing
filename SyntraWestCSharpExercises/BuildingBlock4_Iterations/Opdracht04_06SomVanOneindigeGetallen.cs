using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_06SomVanOneindigeGetallen : ExerciseBase
    {
        public override void RunExercise()
        {
            int getal;
            int som = 0;

            Console.WriteLine("Geef het getal in gescheiden door een enter: ");
            getal = int.Parse(Console.ReadLine());

            while (getal != -1)
            {
                som += getal;
                getal = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"som = {som}");
        }
    }
}
