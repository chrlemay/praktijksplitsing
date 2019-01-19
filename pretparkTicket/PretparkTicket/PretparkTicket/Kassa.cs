using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretparkTicket
{
    class Kassa
    {
        string[] CategorieKlant = { "Kind zonder korting", "Kind met korting", " Volwassen zonder korting", " Volwassen met korting" };
        public int AantalKinderen { get; set; }
        public int AantalKinderenKorting { get; set; }
        public int AantalVolwassen { get; set; }
        public decimal AantalVolwassenKorting { get; set; }

        const decimal KindZonderKorting = 12.5m;
        const decimal KindKorting = 5m;
        const decimal VolwassenZonderKorting = 15m;
        const decimal VolwassenKorting = 6m;

      


        public void VolgendeKlant(int AantalKinderen, int AantalVolwassen, int AantalKinderenKorting, int AantalVolwassenKorting)
        {


            Console.WriteLine("\n  Klant afrekening \n -------------- \n");
            if (AantalVolwassen != 0 || AantalVolwassenKorting != 0)
            {
                Console.WriteLine($" {AantalKinderen,3 } {CategorieKlant[0],25} {KindZonderKorting,4} € =  {AantalKinderen * KindZonderKorting,5} €  ");
                Console.WriteLine($" {AantalVolwassen,3 } {CategorieKlant[2],25} {VolwassenZonderKorting,4} € =  {AantalVolwassen * VolwassenZonderKorting,5} €  ");
                Console.WriteLine($" {AantalKinderenKorting,3 } {CategorieKlant[1],25} {KindKorting,4} € =  {AantalKinderenKorting * KindKorting,5} €  ");
                Console.WriteLine($" {AantalVolwassenKorting,3 } {CategorieKlant[3],25} {VolwassenKorting,4} € =  {AantalVolwassenKorting * VolwassenKorting,5} €  ");
                Console.WriteLine($" TOTAAL \n{ (AantalKinderen * KindZonderKorting) + (AantalVolwassen * VolwassenZonderKorting) + (AantalKinderenKorting * KindKorting) + (AantalVolwassenKorting * VolwassenKorting),7} €\n");
            }
            else
            {
                Console.WriteLine(" Kinderen zonder volwassen kunnen niet naar binnen.");

            }
        }





/*

       public void PrintDag()
        {
            Console.Clear();
            decimal ticketTotaal = 0;
            int catnr = 0;
           // Console.WriteLine($"{uitvoering[keuzeUitvoering - 1]}");
           // lijn = new string('=', uitvoering[keuzeUitvoering].Length);
           // Console.WriteLine(lijn);
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
        }


    */

    }

}
