using System;

namespace SyntraWestCSharpExercises.BuildingBlock6_IntroOOP.Opdracht06_01Kerstmis
{
    public class Speelgoed
    {
        private string naam;

        private bool isGemaakt;

        private bool isIngepakt;
        
        public Speelgoed()
        {
            this.naam = "/";
            this.isGemaakt = false;
            this.isIngepakt = false;
        }

        #region getters en setters

        public string GetNaam()
        {
            return this.naam;
        }

        public void SetNaam(string naam)
        {
            this.naam = naam;
        }

        public bool GetIsGemaakt()
        {
            return this.isGemaakt;
        }

        public void SetIsGemaakt(bool isGemaakt)
        {
            if (isIngepakt)
            {
                Console.WriteLine("Je kan isGemaakt niet veranderend als het speelgoed al ingepakt is.");
            }
            else
            {
                this.isGemaakt = isGemaakt;
            }
        }

        public bool GetIsIngepakt()
        {
            return this.isIngepakt;
        }

        public void SetIsIngepakt(bool isIngepakt)
        {
            if (this.isGemaakt)
            {
                this.isIngepakt = isIngepakt;
            }
            else
            {
                Console.WriteLine("Je kan geen speelgoed inpakken dat nog niet gemaakt is.");
            }
        }

        #endregion

        public override string ToString()
        {
            string speelgoed = $"Status {this.naam}: Gemaakt {(isGemaakt ? "Ja" : "Nee")}, " +
                $"Ingepakt {(isIngepakt ? "Ja" : "Nee")}";

            return speelgoed;
        }
    }
}
