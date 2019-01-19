using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretparkTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Kasticket = new List<int>();
            List<int> TicketAantal = new List<int>();
            int ticketnummer = 0;
            List<int> Ticket = new List<int>();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int keuzeUitvoering = 6;
            int catnr = 0;
            string stop = "";

            string[] CategorieKlant = { " Kind zonder korting", " Volwassen zonder korting", " Kind met korting", " Volwassen met korting" };
            decimal[] CategoriePrijs = { 12.5m, 15m, 5m, 6m, };
            int[] categorieAantal = new int[4];
            string[] uitvoering = { "1) nieuw ticket", "2) tickets weergeven", "3) ticket weizigen ", "4) klant per categorie", "5) dag rapport", "\n\n 0) stoppen " };
           
            while (keuzeUitvoering != 0)
            {
                for (int i = 0; i < uitvoering.Length; i++)
                {
                    Console.WriteLine($" {uitvoering[i]}  ");
                }
                Console.Write($"\n   Maak een keuze : ");
                keuzeUitvoering = int.Parse(Console.ReadLine());

                Console.WriteLine($"{uitvoering[keuzeUitvoering - 1]}");
                string lijn = new string('=', uitvoering[keuzeUitvoering].Length);
                Console.WriteLine(lijn);

                switch (keuzeUitvoering)
                {
                    case 1:
                        // ticket aanmaken 


                        while (stop != "*")
                        {

                            Console.Clear();
                            Console.WriteLine($"{uitvoering[keuzeUitvoering - 1]}");
                            lijn = new string('=', uitvoering[keuzeUitvoering - 1].Length);
                            Console.WriteLine(lijn);
                            Console.WriteLine($" Volgende klant ticketnr : { ticketnummer + 1 }");

                            for (int i = 0; i < CategoriePrijs.Length; i++)
                            {
                                try
                                {
                                    Console.Write($"{CategorieKlant[i],28} aan {CategoriePrijs[i],5} € aantal : ");

                                    categorieAantal[i] = int.Parse(Console.ReadLine());
                                }
                                catch { categorieAantal[i] = 0; }
                            }

                            Kassa kassa = new Kassa();

                            kassa.VolgendeKlant(categorieAantal[0], categorieAantal[1], categorieAantal[2], categorieAantal[3]);
                            if (categorieAantal[1] != 0 || categorieAantal[3] != 0)
                            {
                                ticketnummer++;
                                Kasticket.Add(ticketnummer);
                                catnr = Ticket.Count;

                                for (int i = 0; i < 4; i++)
                                {
                                    // Console.WriteLine(catnr);
                                    // List<int> TicketAantal = new List<int>();
                                    Ticket.Add(categorieAantal[i]);
                                    catnr++;
                                }
                            }

                            Console.WriteLine(" volgend ticket  [ druk 'enter'] [druk '*' voor stoppen]");
                            stop = Console.ReadLine();
                           

                        }

                        break;


                    case 2:
                        // tickets weergeven

                        Console.Clear();
                        decimal totaal = 0;
                        catnr = 0;
                        stop = "";
                        while (stop != "*")
                        {
                            foreach (int ticketnr in Kasticket)
                            {
                                if (ticketnr % 4 == 0)
                                { Console.Clear(); }
                                Console.WriteLine($" klant ticket { ticketnr}");


                                for (int i = 0; i < 4; i++)
                                {
                                    Console.WriteLine($" {CategorieKlant[i],25} { Ticket[catnr],5} aan { CategoriePrijs[i],4}  = { Ticket[catnr] * CategoriePrijs[i],8} €  ");
                                    totaal = totaal + (Ticket[catnr] * CategoriePrijs[i]);
                                    catnr++;
                                }
                                Console.WriteLine($"\n  TICKET TOTAAL = {totaal} "); totaal = 0;
                                lijn = new string('=', 25);
                                Console.WriteLine(lijn);
                                Console.WriteLine(" volgend ticket  [ druk 'enter'] [druk '*' voor stoppen]");
                                stop = Console.ReadLine();
                                if (catnr == Ticket.Count)
                                {
                                    Console.WriteLine("\n alle tickets zijn weergeven");
                                    stop = "*";
                                }
                                Console.WriteLine(lijn + " case 2");

                            }
                        }

                        break;

                    case 3:

                        Console.Clear();
                        Console.WriteLine($"{uitvoering[keuzeUitvoering - 1]}");
                        lijn = new string('=', uitvoering[keuzeUitvoering].Length);
                        Console.WriteLine(lijn);

                        Console.WriteLine("\n niet uitgewerkt ");
                        Console.WriteLine("\n om  vervolgen  [druk '*' voor stoppen]");
                        stop = Console.ReadLine();
                        break;
                    case 4:
                        // overzicht per klant categorie 

                        Console.Clear();
                        //decimal totaal = 0;
                        catnr = 0;
                        stop = "";

                        Console.Clear();
                        Console.WriteLine($"{uitvoering[keuzeUitvoering - 1]}");
                        lijn = new string('=', uitvoering[keuzeUitvoering].Length);
                        Console.WriteLine(lijn);

                        decimal[] totPerCategorie = new decimal[4];

                        foreach (int ticketnr in Kasticket)
                        {
                            if (ticketnr % 3 == 0) { Console.Clear(); }
                            Console.WriteLine($" klant ticket { ticketnr}");


                            for (int i = 0; i < 4; i++)
                            {

                                totPerCategorie[i] = totPerCategorie[i] + (Ticket[catnr] * CategoriePrijs[i]);

                                catnr++;
                            }

                            if (catnr == Ticket.Count)
                            {
                                Console.Clear();
                                Console.WriteLine(" alle tickets zijn weergeven\n");
                                stop = "*";
                            }

                        }
                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine($"{totPerCategorie[i] / CategoriePrijs[i],4} {CategorieKlant[i],25 }  aan { CategoriePrijs[i],8} € = {totPerCategorie[i]} € ");

                        }


                        Console.WriteLine("om  vervolgen ] [druk '*' voor stop]");
                        stop = Console.ReadLine();
                        break;
                    case 5:
                        // dag rapport 

                        Console.Clear();
                        decimal ticketTotaal = 0;
                        catnr = 0;
                        Console.WriteLine($"{uitvoering[keuzeUitvoering - 1]}");
                        lijn = new string('=', uitvoering[keuzeUitvoering].Length);
                        Console.WriteLine(lijn);
                        decimal[] PrijsTotPerCat = new decimal[4];
                        int[] AantKlantenPerCat = new int[4];
                        foreach (int ticketnr in Kasticket)
                        {
                            if (ticketnr % 3 == 0) { Console.Clear(); }
                          
                            for (int i = 0; i < 4; i++)
                            {

                                PrijsTotPerCat[i] = PrijsTotPerCat[i] + (Ticket[catnr] * CategoriePrijs[i]);
                                ticketTotaal = ticketTotaal + (Ticket[catnr] * CategoriePrijs[i]);
                                AantKlantenPerCat[i] = AantKlantenPerCat[i] + Ticket[catnr];
                                catnr++;
                            }

                            if (catnr == Ticket.Count)
                            {
                                Console.WriteLine(" alle tickets zijn Verwerkt");
                                stop = "*";
                            }

                        }
                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine($"{PrijsTotPerCat[i] / CategoriePrijs[i],4} {CategorieKlant[i],25 }  aan { CategoriePrijs[i],8} € = {PrijsTotPerCat[i]} € ");

                        }
                        Console.WriteLine($" Totaal van alle tickets  { ticketTotaal}\n");
                        Console.WriteLine($" kortingen toegekend aan kinderen {(PrijsTotPerCat[2] / CategoriePrijs[2]) * (CategoriePrijs[0] - CategoriePrijs[2])}    ");
                        Console.WriteLine($" kortingen toegekend aan volwassen {(PrijsTotPerCat[3] / CategoriePrijs[3]) * (CategoriePrijs[1] - CategoriePrijs[3])} \n");

                        
                        Console.WriteLine("om  vervolgen ] [druk '*' voor stoppen]");
                        stop = Console.ReadLine();
                        break;
                    case 0:

                        Console.Clear();
                        Console.WriteLine($"{uitvoering[keuzeUitvoering - 1]}");
                        lijn = new string('=', uitvoering[keuzeUitvoering].Length);

                        Console.WriteLine(lijn);

                        stop = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine(" ongeldige ingave!");
                        break;
                }
            }
        }
    }
}
