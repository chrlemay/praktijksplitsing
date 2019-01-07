using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_13CirkelRechthoekVierkant : ExerciseBase
    {
        public override void RunExercise()
        {
            int keuzeVorm = 0;
            int keuzeBerekenen = 0;

            float lengte = 0;
            float breedte = 0;
            float diameter = 0;

            float oppervlakte = 0;
            float omtrek = 0;

            string vorm = "";
            string berekenen = "";

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Maak uw keuze voor de vorm.");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Cirkel");
            Console.WriteLine("2. Rechthoek");
            Console.WriteLine("3. Vierkant");
            Console.WriteLine();
            
            keuzeVorm = int.Parse(Console.ReadLine());
            
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Maak uw keuze voor de berekening.");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Omtrek");
            Console.WriteLine("2. Oppervlakte");
            Console.WriteLine("");
            
            keuzeBerekenen = int.Parse(Console.ReadLine());

            switch (keuzeBerekenen)
            {
                case 1:
                    berekenen = "Omtrek";
                    break;
                case 2:
                    berekenen = "Oppervlakte";
                    break;
                default:
                    berekenen = "Onbekend";
                    break;
            }

            switch (keuzeVorm)
            {
                case 1:
                    vorm = "Cirkel";
                    
                    Console.WriteLine("Geef de diameter in van de Circel:");
                    diameter = float.Parse(Console.ReadLine());

                    omtrek = (float)(diameter * Math.PI);
                    oppervlakte = (float)(Math.Pow(diameter / 2, 2) * Math.PI);

                    break;

                case 2:
                    vorm = "Rechthoek";
                    
                    Console.WriteLine("Geef de Lengte in van de Rechthoek:");
                    lengte = float.Parse(Console.ReadLine());

                    Console.WriteLine("Geef de Breedte in van de Rechthoek:");
                    breedte = float.Parse(Console.ReadLine());

                    omtrek = 2 * (lengte + breedte);
                    oppervlakte = lengte * breedte;

                    break;

                case 3:
                    vorm = "Vierkant";
                    
                    Console.WriteLine("Geef de zijde in van het vierkant:");
                    lengte = float.Parse(Console.ReadLine());

                    omtrek = 4 * lengte;
                    oppervlakte = (float)Math.Pow(lengte, 2);

                    break;

                default:
                    vorm = "Onbekend";
                    break;
            }

            if (vorm != "Onbekend" && berekenen != "Onbekend")
            {
                Console.WriteLine($"Je hebt gekozen om de {berekenen} van een {vorm} te bepalen.");
                Console.WriteLine("Je hebt hierbij gekozen voor de volgende gegevens :");

                switch (vorm)
                {
                    case "Cirkel":
                        Console.WriteLine($"Diameter: {diameter}", diameter);
                        break;
                    case "Rechthoek":
                        Console.WriteLine($"Lengte: {lengte}");
                        Console.WriteLine($"Breedte: {breedte}");
                        break;
                    case "Vierkant":
                        Console.WriteLine($"Zijde: {lengte}");
                        break;
                }

                switch (keuzeBerekenen)
                {
                    case 1:
                        Console.WriteLine($"De omtrek: {omtrek}");
                        break;
                    case 2:
                        Console.WriteLine($"De oppervlakte: {oppervlakte}");
                        break;
                }
            }
            else
            {
                Console.WriteLine("De opgegeven waarden zijn niet correct.\nHet was onmogelijk om de omtrek of de oppervlakte te berekenen.\n");
            }

        }
    }
}
