using System;

namespace SyntraWestCSharpExercises.Variables
{
    public class Opdracht01_04KostprijsVervenVanDeuren : ExerciseBase
    {
        const float _basicPrijs = 22.4f;
        const float _modernPrijs = 33.4f;

        public override void RunExercise()
        {
            // zorgt ervoor dat de computer het € teken herkent in je programma
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            float breedte, lengte, oppervlakte, hoeveelheidVerf;

            string klant;

            float prijsBasic, prijsModern;

            int laagKeuze;
            int aantalDeuren;

            Console.WriteLine("Geef je klantnaam in:");
            klant = Console.ReadLine();

            Console.WriteLine("Geef de breedte in:");
            breedte = float.Parse(Console.ReadLine());

            Console.WriteLine("Geef de lengte in:");
            lengte = float.Parse(Console.ReadLine());

            Console.WriteLine("Hoeveel lagen? (antwoorden met 1 of 2):");
            laagKeuze = int.Parse(Console.ReadLine());

            Console.WriteLine("Hoeveel deuren wil je schilderen:");
            aantalDeuren = int.Parse(Console.ReadLine());

            oppervlakte = lengte * breedte * aantalDeuren;
            hoeveelheidVerf = oppervlakte * laagKeuze;

            prijsBasic = hoeveelheidVerf * _basicPrijs;
            prijsModern = hoeveelheidVerf * _modernPrijs;

            
            Console.WriteLine($"{klant} moet {hoeveelheidVerf:N2} m² schilderen.");
            Console.WriteLine($"De kostprijs voor een Basic bedraagt: € {prijsBasic:N2}");
            Console.WriteLine($"De kostprijs voor een Modern bedraagt: € {prijsModern:N2}");
        }
    }
}
