using System;

namespace SyntraWestCSharpExercises.Variables
{
    public class Opdracht01_03AankopenGroentenFruit : ExerciseBase
    {
        public override void RunExercise()
        {
            // zorgt ervoor dat de computer het € teken herkent in je programma
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string naam = "Theodore";

            string kilo = "Kg";
            string bakje = "Bakje";

            string appels = "appels";
            string aardappelen = "aardappelen";
            string peren = "peren";
            string aardbeien = "aardbeien";

            float aantalKiloAppels = 2;
            float aantalKiloAardappelen = 5;
            float aantalKiloPeren = 3.5f;
            int aantalBakjesAardbeien = 1;

            float euroPerKiloAppels = 2.4f;
            float euroPerKiloAardappelen = .75f;
            float euroPerKiloPeren = 1.8f;
            float euroPerBakjeAardbeien = 2.84f;

            float totaleKostAppels = aantalKiloAppels * euroPerKiloAppels;
            float totaleKostAardappelen = aantalKiloAardappelen * euroPerKiloAardappelen;
            float totaleKostPeren = aantalKiloPeren * euroPerKiloPeren;
            float totaleKostAardbeien = aantalBakjesAardbeien * euroPerBakjeAardbeien;

            Console.WriteLine($"{naam} koopt volgende artikelen op de markt.");
            Console.WriteLine($"{aantalKiloAppels, 3} {kilo, 7} {appels, 12} aan {euroPerKiloAppels:N2} €/{kilo,7} is {totaleKostAppels:N2}");
            Console.WriteLine($"{aantalKiloAardappelen, 3} {kilo, 7} {aardappelen, 12} aan {euroPerKiloAardappelen:N2} €/{kilo,7} is {totaleKostAardappelen:N2}");
            Console.WriteLine($"{aantalKiloPeren, 3} {kilo, 7} {peren, 12} aan {euroPerKiloPeren:N2} €/{kilo,7} is {totaleKostPeren:N2}");
            Console.WriteLine($"{aantalBakjesAardbeien, 3} {bakje, 7} {aardbeien, 12} aan {euroPerBakjeAardbeien:N2} €/{bakje,7} is {totaleKostAardbeien:N2}");
            Console.WriteLine($"{naam} moet in totaal €{totaleKostAppels + totaleKostAardappelen + totaleKostPeren + totaleKostAardbeien:N2} betalen.");
        }
    }
}
