using SyntraWestCSharpExercises.BuildingBlock8_Methods;
using SyntraWestCSharpExercises.BuildingBlock9_Classes.Opdracht09_04Rekenmachine;
using System;

namespace SyntraWestCSharpExercises.BuildingBlock9_Classes.Opdracht09_04Rekenmachine
{
    class Opdracht09_04Rekenmachine : ExerciseBase
    {
        public override void RunExercise()
        {
            double getal1 = 0;
            double getal2 = 0;
            string stop = "";
            int antwoord = 0;
            do                     // lus van de soort berekening 
            {
                string stp = "";

                string[] berekening = { "  stoppen", "  Som", "  Verschil", "  Product", "  Quotiënt", "  Macht" };

                Console.WriteLine("  Welke berekening wil je maken  ? ");

                // lijn lengt wordt berkend in de methode TrekLijn 
                string lijn = new string('=', 34);
                Console.WriteLine(lijn);
               //string lijn = "                               ";
                char ch = '-';
               // Bereken.TrekLijn(lijn, ch);


                //Console.WriteLine($" 1){ berekening[1] } \n 2){ berekening[2]   }\n 3){ berekening[3] }\n 4){ berekening[4]  }\n 5){ berekening[5] }\n\n 0){ berekening[0]   }");
                for (int i = 1; i < berekening.Length; i++)
                {
                    Console.WriteLine($" {i})  {berekening[i]}");
                }
                Console.WriteLine($"\n {0})  {berekening[0]}");


                antwoord = int.Parse(Console.ReadLine());



                Console.WriteLine($" {berekening[antwoord]}");


                // lengte van het gekozen' berekening' om lijn te trekken 
                lijn = berekening[antwoord];
                ch = '*';
                Bereken.TrekLijn(lijn, ch);
                if (antwoord != 0)
                {


                    while (stp != "stp")         // lus voor het ingeven van getallen 
                    {
                        lijn = "                       ";
                        ch = '_';
                        Bereken.TrekLijn(lijn, ch);
                        Bereken nieuweBerekening = new Bereken();
                        if (antwoord != 0)
                        {
                            
                                Console.WriteLine(" geef getal  1 in: ");
                                getal1 = double.Parse(Console.ReadLine());
                                if (getal1 == 0)
                                {
                                    stp = "stp";
                                    Console.Clear();

                                }
                                else
                                {
                                    Console.WriteLine(" geef getal  2 in: ");
                                    getal2 = double.Parse(Console.ReadLine());
                                }
                           

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
                                    nieuweBerekening.Machtvan(getal1, getal2);
                                    break;
                                default:
                                    Console.WriteLine(" ongeldige ingave!");
                                    break;
                            }

                        }
                    }


                }

            
               else  
                    {
                stop = "stop";

            }
        }

            while (stop != "stop");
        }
}
}
