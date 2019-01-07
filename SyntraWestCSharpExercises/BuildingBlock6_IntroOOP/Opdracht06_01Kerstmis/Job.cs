namespace SyntraWestCSharpExercises.BuildingBlock6_IntroOOP.Opdracht06_01Kerstmis
{
    public class Job
    {
        private string naam;

        private readonly decimal bedragPerVerwerking;

        public Job(string naam, decimal bedragPerVerwerking)
        {
            this.naam = naam;
            this.bedragPerVerwerking = bedragPerVerwerking;
        }

        public string GetNaam()
        {
            return this.naam;
        }

        public void SetNaam(string naam)
        {
            this.naam = naam;
        }

        public decimal GetBedragPerVerwerking()
        {
            return this.bedragPerVerwerking;
        }
    }
}
