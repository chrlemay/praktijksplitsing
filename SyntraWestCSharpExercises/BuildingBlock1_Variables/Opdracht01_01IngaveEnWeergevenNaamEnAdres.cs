namespace SyntraWestCSharpExercises.Variables
{
    using System;

    public class Opdracht01_01IngaveEnWeergevenNaamEnAdres : ExerciseBase
    {
        //Schrijf in deze method je code
        public override void RunExercise()
        {
            string voornaam;
            string naam;
            string adres;

            Console.WriteLine("Geef je voornaam.");
            voornaam = Console.ReadLine();

            Console.WriteLine("Geef je familienaam.");
            naam = Console.ReadLine();

            Console.WriteLine("geef je adres.");
            adres = Console.ReadLine();

            // String interpolation
            Console.WriteLine($"{voornaam} {naam} woont in {adres}");

            // String concatination
            // Console.WriteLine(voornaam + " " + naam + " woont in " + adres);

            // String with parameters
            // Console.WriteLine("{0} {1} woont in {2}", voornaam, naam, adres);
            
        }
    }
}
