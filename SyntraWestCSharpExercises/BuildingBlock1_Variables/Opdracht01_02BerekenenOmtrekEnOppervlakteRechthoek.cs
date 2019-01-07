using System;

namespace SyntraWestCSharpExercises.Variables
{
    public class Opdracht01_02BerekenenOmtrekEnOppervlakteRechthoek : ExerciseBase
    {
        public override void RunExercise()
        {
            int lengte, breedte;
            double omtrek, oppervlakte;

            Console.WriteLine("Geef de lengte van je rechthoek.");
            string lengteString = Console.ReadLine();
            lengte = int.Parse(lengteString);

            Console.WriteLine("Geef de breedte van je rechthoek.");
            breedte = int.Parse(Console.ReadLine());

            omtrek = ( 2 * lengte ) + ( 2 * breedte );
            oppervlakte = lengte * breedte;
            
            Console.WriteLine($"Omtrek rechthoek: {omtrek}");
            Console.WriteLine($"Oppervlakte rechthoek: {oppervlakte}");
        }
    }
}
