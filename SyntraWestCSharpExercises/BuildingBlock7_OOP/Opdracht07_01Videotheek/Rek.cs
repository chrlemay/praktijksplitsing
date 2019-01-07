using System;

namespace SyntraWestCSharpExercises.BuildingBlock7_OOP.Opdracht07_01Videotheek
{
    public class Rek
    {
        public const int aantalFilmsPerRek = 3;
        private int aantalFilmsInRek = 0;

        public Rek()
        {
            Films = new Film[aantalFilmsPerRek];
        }

        public Film[] Films { get; set; }
        public Kast Kast { get; set; }

        public Film[] GeefAlleFilmsTerug()
        {
            return Films;
        }

        public void PrintRek(int rekNummerInKast)
        {
            Console.WriteLine($"REK {rekNummerInKast}");
            
            foreach(Film film in Films)
            {
                if(film == null)
                {
                    return;
                }

                Console.WriteLine($"\t-{film.ToString()}");
            }
        }

        public bool VoegFilmToeAanRek(Film film)
        {
            if(aantalFilmsInRek == aantalFilmsPerRek)
            {
                Console.WriteLine("Kan geen films meer toevoegen aan dit rek.");
                return false;
            }

            Films[aantalFilmsInRek] = film;
            aantalFilmsInRek++;
            return true;
        }
    }
}
