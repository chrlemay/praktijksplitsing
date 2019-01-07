using System;

namespace SyntraWestCSharpExercises.BuildingBlock7_OOP.Voorbeeld07_00Boeken
{
    public class Boekenrek
    {
        // Default constructor
        public Boekenrek() 
        {
            this.Category = string.Empty;
            this.Rek = new Boek[arrayGrootte];
        }

        // OverLoad constructor
        public Boekenrek(string category)
        {
            this.Category = category;
            this.Rek = new Boek[arrayGrootte];
        }

        public static int bladzijdenPerRek = 1000;

        private const int arrayGrootte = 50;

        private int eerstVolgendeVrijePlaatsInRek = 0;

        private string category;

        public string Category
        {
            get
            {
                return this.category;
            }

            set
            {
                this.category = value;
            }
        }

        private Boek[] rek;

        public Boek[] Rek
        {
            get
            {
                return this.rek;
            }

            set
            {
                if(rek == null)
                {
                    this.rek = new Boek[arrayGrootte];
                }

                rek = value;
            }
        }

        private int BladzijdenOverInRek()
        {
            int bladzijdenInRek = 0;

            foreach (Boek boek in this.Rek)
            {
                if(boek != null)
                {
                    bladzijdenInRek += boek.Bladzijden;
                }
            }

            return bladzijdenPerRek - bladzijdenInRek;
        }

        public void VoegBoekToe(Boek boek)
        {
            // Boekenrek moet een category hebben
            if (string.IsNullOrWhiteSpace(this.Category))
            {
                Console.WriteLine("Je kan geen boek toevoegen aan dit rek, dit rek heeft nog geen category");
                return;
            }
            
            // boekenrek met genoeg ruimte hebben om een nieuw boek toe te voegen
            if(boek.Bladzijden > BladzijdenOverInRek())
            {
                Console.WriteLine($"Het boek {boek.ToString()} Met {boek.Bladzijden} bladzijden, Past Niet meer in het rek.");
                return;
            }

            // Als boek al geplaats is in een rek, kan je hem niet meer toevoegen.
            if (boek.GeplaatsInRek)
            {
                Console.WriteLine($"{boek.ToString()} is al geplaats in een rek.");
                return;
            }

            rek[eerstVolgendeVrijePlaatsInRek] = boek;
            eerstVolgendeVrijePlaatsInRek++;
            boek.GeplaatsInRek = true;
            Console.WriteLine($"Het boek {boek.ToString()}, werd succesvol toegevoegd.");
        }

        public void PrintBoekenInRek()
        {
            Console.WriteLine($"Lijst boeken in boekenrek met category {this.Category}");
            for(int i = 0; i < eerstVolgendeVrijePlaatsInRek; i++)
            {
                Boek boek = rek[i];
                Console.WriteLine(" - " + boek.ToString());
            }
        }
    }
}
