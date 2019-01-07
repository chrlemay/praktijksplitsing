using System;

namespace SyntraWestCSharpExercises.BuildingBlock6_IntroOOP.Opdracht06_00Facturen
{
    public class Factuur
    {
        private Bedrijf leverancier;
        private Btw btw;
        private decimal bedragExclusiefBtw;
        private bool isBetaald;

        public Factuur(Bedrijf bedrijf, Btw btw, decimal bedragExclusiefBtw)
        {
            if (bedrijf.GetMijnBedrijf())
            {
                throw new InvalidOperationException("Het bedrijf is mijn bedrijf, mag niet.");
            }

            this.leverancier = bedrijf;
            this.btw = btw;
            this.bedragExclusiefBtw = bedragExclusiefBtw;
        }

        public Factuur()
        {
        }

        public Bedrijf GetBedrijf()
        {
            return this.leverancier;
        }

        public Btw GetBtw()
        {
            return this.btw;
        }

        public decimal GetBedragExclusiefBtw()
        {
            return this.bedragExclusiefBtw;
        }

        public bool GetIsBetaald()
        {
            return this.isBetaald;
        }

        public void SetIsBetaald(bool isBetaald)
        {
            this.isBetaald = isBetaald;
        }

        public decimal BedragInclusiefBtw()
        {
            return this.bedragExclusiefBtw * (1 + this.btw.GetPercentage() / 100);
        }

        public override string ToString()
        {
            if(this.leverancier == null)
            {
                return "Geen geldige factuur";
            }
            string factuur = $"Factuur: bedrijf {this.leverancier.GetNaam()}, " +
                $"{this.btw.GetPercentage()}% btw + {this.bedragExclusiefBtw} = {this.BedragInclusiefBtw()}";

            return factuur;
        }
    }
}