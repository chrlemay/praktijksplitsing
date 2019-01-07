using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_06Vrachtwagen : ExerciseBase
    {
        public override void RunExercise()
        {
            float vrachtwagenLengte = 3;
            float vrachtwagenBreedte = 1.5f;
            float vrachtwagenHoogte = 2;
            float vrachtwagenInhoud, vrachtwagenInhoudOver;

            float pakjeLengte = 0;
            float pakjeBreedte = 0;
            float pakjeHoogte = 0;
            float pakjeInhoud = 0;

            vrachtwagenInhoud = vrachtwagenLengte * vrachtwagenBreedte * vrachtwagenHoogte;
            vrachtwagenInhoudOver = vrachtwagenInhoud - 4.5f;

            Console.WriteLine("Geef de lengte pakje in.");
            pakjeLengte = float.Parse(Console.ReadLine());

            Console.WriteLine("Geef de breedte pakje in.");
            pakjeBreedte = float.Parse(Console.ReadLine());

            Console.WriteLine("Geef de hoogte pakje in.");
            pakjeHoogte = float.Parse(Console.ReadLine());

            pakjeInhoud = pakjeLengte * pakjeBreedte * pakjeHoogte;

            Console.WriteLine($"De vrachtwagen heeft een totale inhoud van {vrachtwagenInhoud}m³.");
            Console.WriteLine($"Er zitten al pakketjes in van 4.5m³, er kan nog {vrachtwagenInhoudOver} m³ bij.");
            Console.WriteLine($"en je wil een pakje van {pakjeInhoud}m³ bijladen.");

            if (vrachtwagenInhoudOver >= pakjeInhoud)
            {
                Console.WriteLine($"Dit zal nog lukken.");
            }
            else
            {
                Console.WriteLine($"Dit zal niet lukken.");
            }
        }
    }
}
