using System;

namespace SyntraWestCSharpExercises.BuildingBlock6_IntroOOP.Opdracht06_00Facturen
{
    public class Bedrijf
    {
        private string naam;
        private bool mijnBedrijf;
        private decimal kapitaal;
        private Factuur[] facturen;
        
        #region getter and setter

        public string GetNaam()
        {
            return this.naam;
        }

        public void SetNaam(string naam)
        {
            this.naam = naam;
        }

        public bool GetMijnBedrijf()
        {
            return this.mijnBedrijf;
        }

        public void SetMijnBedrijf(bool mijnBedrijf)
        {
            this.mijnBedrijf = mijnBedrijf;
        }

        public Factuur[] GetFacturen()
        {
            return this.facturen;
        }

        public decimal GetKapitaal()
        {
            return this.kapitaal;
        }

        #endregion

        public Bedrijf(string naam, bool mijnBedrijf, decimal kapitaal)
        {
            this.naam = naam;
            this.mijnBedrijf = mijnBedrijf;
            this.kapitaal = kapitaal;

            this.facturen = new Factuur[5];

            for(int i = 0; i < facturen.Length; i++)
            {
                facturen[i] = new Factuur();
            }
        }

        public void BetaalFactuur(int factuurIndex)
        {
            Factuur factuur = this.facturen[factuurIndex];

            if (!this.mijnBedrijf)
            {
                Console.WriteLine("Enkel mijn bedrijf mag facturen betalen");
                return;
            }

            if (factuur.GetBedrijf() == null)
            {
                Console.WriteLine("Deze factuur is nog niet goed opgemaakt.");
                return;
            }

            if (factuur.GetIsBetaald())
            {
                Console.WriteLine("Deze factuur is al betaald.");
                return;
            }

            decimal kostFactuur = factuur.BedragInclusiefBtw();

            if (this.kapitaal - kostFactuur < 0)
            {
                Console.WriteLine("Je bent niet kapitaal krachtig om deze factuur te betalen.");
                return;
            }

            this.kapitaal -= kostFactuur;
            factuur.SetIsBetaald(true);

            Console.WriteLine($"Succesvolle betaalt voor {factuur.ToString()}");
        }

        private void PrintOnBetaaldeFacturen()
        {
            Console.WriteLine("Onbetaalde facturen");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            
            foreach(var factuur in this.facturen)
            {
                if (!factuur.GetIsBetaald())
                {
                    Console.WriteLine(factuur);
                }
            }
        }

        private void PrintBetaaldeFacturen()
        {
            Console.WriteLine("Betaalde facturen");
            Console.WriteLine("-------------------");
            Console.WriteLine();

            foreach (var factuur in this.facturen)
            {
                if (factuur.GetIsBetaald())
                {
                    Console.WriteLine(factuur);
                }
            }
        }

        public void PrintRapport()
        {
            if (!this.mijnBedrijf)
            {
                Console.WriteLine("Enkel mijn bedrijf mag rapporten afdrukken.");
                return;
            }

            Console.WriteLine($"RAPPORT VOOR {this.naam.ToUpper()}");

            PrintOnBetaaldeFacturen();
            Console.WriteLine();
            PrintBetaaldeFacturen();
        }

        public void StelFacuurOp(int factuurIndex, Bedrijf bedrijf, Btw btw, decimal bedragExclusief)
        {
            if(facturen[factuurIndex].GetBedrijf() != null)
            {
                Console.WriteLine("Deze factuur is al opgesteld");
                return;
            }

            if (!this.mijnBedrijf)
            {
                Console.WriteLine("Enkel mijn bedrijf mag facturen opstellen");
                return;
            }

            if (bedrijf.mijnBedrijf)
            {
                Console.WriteLine("Enkel derde bedrijven mogen op de factuur staan");
                return;
            }

            facturen[factuurIndex] = new Factuur(bedrijf, btw, bedragExclusief);
            Console.WriteLine("Succesvol factuur opgesteld");
        }
    }
}
