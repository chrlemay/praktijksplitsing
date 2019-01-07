using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_19Shopping : ExerciseBase
    {
        public override void RunExercise()
        {
            decimal rekeningBedrag = 0;
            decimal productBedrag = 0;
            decimal totaalBedrag = 0;

            Console.WriteLine("Hoeveel geld staat er op uw bankrekening?");

            while (!decimal.TryParse(Console.ReadLine(), out rekeningBedrag))
            {
                Console.WriteLine("Hoeveel geld staat er op uw bankrekening?");
            }

            if (rekeningBedrag <= 0)
            {
                Console.WriteLine("Jammer, we kunnen niet gaan shoppen.");
                return;
            }

            Console.WriteLine("Joepie, we mogen gaan shoppen");

            do
            {
                Console.WriteLine("Geef het bedrag in van het product:");
                string bedrag = Console.ReadLine();

                if(bedrag == "stop")
                {
                    Console.WriteLine("Einde van de aankopen.");
                    break;
                }

                productBedrag = decimal.Parse(bedrag);
                    
                if (rekeningBedrag - productBedrag >= 0)
                {
                    Console.WriteLine($"Product gekocht {productBedrag}");
                    totaalBedrag += productBedrag;
                    rekeningBedrag -= productBedrag;
                }
                else
                {
                    Console.WriteLine("Het product is te duur. Kies een ander product.");
                }
            }
            while (rekeningBedrag > 0);

            Console.WriteLine($"Totaal aangekocht: {totaalBedrag:N2}, Eindbedrag : {rekeningBedrag:N2}");
        }
    }
}
