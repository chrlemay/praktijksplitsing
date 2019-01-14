using System;

namespace Rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double getal1 = 0;
            double getal2 = 0;
            string stop = "";

            do                     // lus van de berekening 
            {
                string stp = "";

                string[] berekening = { "  stoppen", "  Som", "  Verschil", "  Product", "  Quotiënt", "  Macht" };

                Console.WriteLine("  Welke berekening wil je maken  ? ");

                // lijn lengt wordt berkend in de methode TrekLijn 
                string lijn = "                               ";
                char ch = '-';
                Bereken.TrekLijn(lijn, ch);


                Console.WriteLine($" 1){ berekening[1] } \n 2){ berekening[2]   }\n 3){ berekening[3] }\n 4){ berekening[4]  }\n 5){ berekening[5] }\n\n 0){ berekening[0]   }");

                int antwoord = int.Parse(Console.ReadLine());
                Console.WriteLine($" {berekening[antwoord]}");

                // lengte van het gekozen' berekening'
                lijn = berekening[antwoord];
                ch = '*';
                Bereken.TrekLijn(lijn, ch);

                while (stp != "stp")         // lus voor het ingeven van getallen 
                {
                    if (antwoord == 0) { }

                    else
                    {
                        Console.WriteLine($"==============================");
                        Console.Write(" geef getal  1 in: ");
                        getal1 = double.Parse(Console.ReadLine());
                        if (getal1 == 0) { stp = "stp"; }
                        else
                        {
                            Console.Write(" geef getal  2 in: ");
                            getal2 = double.Parse(Console.ReadLine());
                        }
                    }


                    Bereken nieuweBerekening = new Bereken(getal1, getal2);

                    switch (antwoord)
                    {
                        case 1:
                            nieuweBerekening.Optellen(getal1, getal2);
                            break;
                        case 2:
                            nieuweBerekening.Aftrekken(getal1, getal2);
                            break;
                        case 3:
                            nieuweBerekening.Vermenigvuldigen(getal1, getal2);
                            break;

                        case 4:
                            nieuweBerekening.Delen(getal1, getal2);
                            break;

                        case 5:
                            nieuweBerekening.Macht(getal1, getal2);
                            break;
                        case 0:
                            stop = "stop";
                            break;


                        default:
                            Console.WriteLine(" ongeldige ingave!");
                            break;

                    }
                }

            }
            while (stop != "stop");

        }
    }
}
