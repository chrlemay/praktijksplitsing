using System;

namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_06BepaalPlaatswaarden : ExerciseBase
    {
        public override void RunExercise()
        {
            int getal;
            int duizendTallen, honderTallen, tienTallen, eenheden;

            Console.WriteLine("Geen een getal >= 999 en <= 9999 in:");
            getal = int.Parse(Console.ReadLine());

            duizendTallen = getal / 1000;
            getal %= 1000; // <=> getal -= duizendTallen * 1000;

            honderTallen = getal / 100;
            getal %= 100; // <=> getal -= duizendTallen * 100;

            tienTallen = getal / 10;
            getal %= 10; // <=> getal -= duizendTallen * 10;

            eenheden = getal;

            Console.WriteLine("Het getal bestaat uit:");
            Console.WriteLine($"{duizendTallen} duizendTallen");
            Console.WriteLine($"{honderTallen} honderTallen");
            Console.WriteLine($"{tienTallen} tienTallen");
            Console.WriteLine($"{eenheden} eenheden");
        }
    }
}
