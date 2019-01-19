using System;
using System.Collections.Generic;
using System.Text;

namespace SyntraWestCSharpExercises.BuildingBlock9_Classes.Opdracht09_05Pretpark
{
    class Kassa //: Opdracht09_05Pretpark
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
                Console.WriteLine($"   toegestane korting aan kinderen  { AantalKinderenKorting *( KindZonderKorting- KindKorting)  } €");
                Console.WriteLine($" {AantalVolwassenKorting,3 } {CategorieKlant[3],25} {VolwassenKorting,4} € =  {AantalVolwassenKorting * VolwassenKorting,5} €  ");
                Console.WriteLine($"   toegestane korting aan volwassen  { AantalVolwassenKorting * (VolwassenZonderKorting - VolwassenKorting)  } €");
                Console.WriteLine($" TOTAAL \n{ (AantalKinderen * KindZonderKorting) + (AantalVolwassen * VolwassenZonderKorting) + (AantalKinderenKorting * KindKorting) + (AantalVolwassenKorting * VolwassenKorting),7} €\n");
            }
            else
            {
                Console.WriteLine(" Kinderen zonder volwassen kunnen niet naar binnen.");

            }
        }





        public void PrintAlleTickets(int v1, int v2, int v3, int v4)
        {
            Console.WriteLine($" {AantalKinderen,3 } {CategorieKlant[0],25} {KindZonderKorting,4} € =  {AantalKinderen * KindZonderKorting,5} €  ");
            Console.WriteLine($" {AantalVolwassen,3 } {CategorieKlant[2],25} {VolwassenZonderKorting,4} € =  {AantalVolwassen * VolwassenZonderKorting,5} €  ");
            Console.WriteLine($" {AantalKinderenKorting,3 } {CategorieKlant[1],25} {KindKorting,4} € =  {AantalKinderenKorting * KindKorting,5} €  ");
            Console.WriteLine($" {AantalVolwassenKorting,3 } {CategorieKlant[3],25} {VolwassenKorting,4} € =  {AantalVolwassenKorting * VolwassenKorting,5} €  ");
            Console.WriteLine($"   toegestane Korting  { AantalVolwassenKorting* (VolwassenZonderKorting - VolwassenKorting) } ");
            Console.WriteLine($" TOTAAL \n{ (AantalKinderen * KindZonderKorting) + (AantalVolwassen * VolwassenZonderKorting) + (AantalKinderenKorting * KindKorting) + (AantalVolwassenKorting * VolwassenKorting),7} €");
        }


            //public void PrintDag()



        

    }

}













    /*
            int aantalKinderenMetKorting;
            int aantalKinderenZonderKorting;
            int aantalVolwassenMetKorting;
            int aantalVolwassenZonderKorting;

            decimal subtotalKzk = 0;
            decimal subtotalKmk = 0;
            decimal subtotalVmk = 0;
            decimal subtotalVzk = 0;



    public void VolgendeKlant(int AantalKinderen, int AantalVolwassen, int AantalKinderenKorting, int AantalVolwassenKorting)
{



   decimal subtotalKmk = aantalKinderenMetKorting * KindMetKorting;
   decimal subtotalKzk = aantalKinderenZonderKorting* KindZonderKorting;
   decimal subtotalVmk = aantalVolwassenMetKorting * VolwassenMetKorting;
   decimal subtotalVzk = aantalVolwassenZonderKorting * VolwassenZonderKorting;
    decimal totaalTicket = subtotalKmk + subtotalKzk + subtotalVmk + subtotalVzk;
    decimal totaalKortingOpTicket = ((aantalKinderenMetKorting * KindZonderKorting) - subtotalKmk) + ((aantalVolwassenMetKorting * VolwassenZonderKorting) - subtotalVmk);
}



{
    Console.WriteLine(" volgende klant : \n ================");


        Console.WriteLine($"{aantalKinderenMetKorting } aan { KindMetKorting } = { subtotalKmk  } ");
        Console.WriteLine($"{aantalKinderenZonderKorting } aan { KindZonderKorting } = { subtotalKzk}");
       */









