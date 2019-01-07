using System;

namespace SyntraWestCSharpExercises.BuildingBlock7_OOP.Opdracht07_01Videotheek
{
    public class Kast
    {
        private const int aantalRekkenPerKast = 2;
        public const int maxAantalFilmsPerKast = aantalRekkenPerKast * Rek.aantalFilmsPerRek;
        
        public Genre Genre { get; set; }
        public Rek[] Rekken { get; set; }

        public Kast(Genre genre, Rek[] rekken)
        {
            Genre = genre;
            Rekken = rekken;
        }

        public void Printkast()
        {
            Console.WriteLine($"Kast met genre '{Genre.Naam}'");
            Console.WriteLine("----------------------------");
            for(int i = 0; i < Rekken.Length; i++)
            {
                Rek rek = Rekken[i];
                rek.PrintRek(i + 1);
            }
        }
    }
}
