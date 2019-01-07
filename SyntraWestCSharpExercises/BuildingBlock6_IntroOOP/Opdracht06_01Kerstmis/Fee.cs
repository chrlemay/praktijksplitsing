using System;

namespace SyntraWestCSharpExercises.BuildingBlock6_IntroOOP.Opdracht06_01Kerstmis
{
    public class Fee
    {
        private string naam;

        private string voornaam;

        private readonly Job job;

        private int aantalSpeelgoedVerwerkt;

        public Fee(string naam, string voornaam, Job job)
        {
            this.naam = naam;
            this.voornaam = voornaam;
            this.job = job;
            this.aantalSpeelgoedVerwerkt = 0;
        }

        #region getters en setters

        public Job GetJob()
        {
            return this.job;
        }

        #endregion

        public string GetVolledigeNaam()
        {
            return $"{voornaam} {naam}";
        }

        public decimal VerdiendBedrag()
        {
            return aantalSpeelgoedVerwerkt * job.GetBedragPerVerwerking();
        }

        public void MaakSpeelgoed(Speelgoed speelgoed, string speelgoedNaam)
        {
            if(this.job.GetNaam() == "Inpakker")
            {
                Console.WriteLine($"Kan geen speelgoed maken, {GetVolledigeNaam()} is een inpakker.");
                return;
            }

            if (speelgoed.GetIsGemaakt())
            {
                Console.WriteLine($"Er is al speelgoed op deze plaats van de kast gemaakt.");
                return;
            }

            speelgoed.SetIsGemaakt(true);
            speelgoed.SetNaam(speelgoedNaam);

            aantalSpeelgoedVerwerkt++;

            Console.WriteLine($"{GetVolledigeNaam()} heeft succesvol, '{speelgoedNaam}' aangemaakt.");
        }

        public void PakSpeelgoedIn(Speelgoed speelgoed)
        {
            if (this.job.GetNaam() == "Maker")
            {
                Console.WriteLine($"Kan geen speelgoed inpakken, {GetVolledigeNaam()} is een maker.");
                return;
            }

            if (!speelgoed.GetIsGemaakt())
            {
                Console.WriteLine($"Kan geen speelgoed inpakken dat nog niet gemaakt is");
                return;
            }

            if (speelgoed.GetIsIngepakt())
            {
                Console.WriteLine($"'{speelgoed.GetNaam()}' is al ingepakt.");
                return;
            }

            speelgoed.SetIsIngepakt(true);

            aantalSpeelgoedVerwerkt++;

            Console.WriteLine($"{GetVolledigeNaam()} heeft succesvol, '{speelgoed.GetNaam()}' ingepakt.");
        }
    }
}
