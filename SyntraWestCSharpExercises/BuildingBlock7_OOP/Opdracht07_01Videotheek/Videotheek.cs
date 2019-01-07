using System;

namespace SyntraWestCSharpExercises.BuildingBlock7_OOP.Opdracht07_01Videotheek
{
    public class Videotheek
    {
        private const int aantalKasten = 3;
        private const int maxAantalFilmsInVideoTheek = aantalKasten * Kast.maxAantalFilmsPerKast;
        private int volgendeVrijeIndexVoorFilms = 0;
        
        public Kast[] Kasten { get; set; }
        public Film[] Films { get; set; }

        public Videotheek(Kast[] kasten)
        {
            Kasten = kasten;
            Films = new Film[maxAantalFilmsInVideoTheek];
        }

        public Film[] ZoekFilmOpTitel(string titel)
        {
            Film[] terugTeGevenFilms = new Film[maxAantalFilmsInVideoTheek];
            int eerstVolgendeVrijeIndex = 0;

            foreach(Film film in Films)
            {
                if(film == null)
                {
                    break;
                }

                if(film.Titel == titel)
                {
                    terugTeGevenFilms[eerstVolgendeVrijeIndex] = film;
                    eerstVolgendeVrijeIndex++;
                }
            }

            return terugTeGevenFilms;
        }

        public Film[] ZoekFilmOpRegisseur(string regisseur)
        {
            Film[] terugTeGevenFilms = new Film[maxAantalFilmsInVideoTheek];
            int eerstVolgendeVrijeIndex = 0;

            foreach (Film film in Films)
            {
                if (film == null)
                {
                    break;
                }

                if (film.Regisseur == regisseur)
                {
                    terugTeGevenFilms[eerstVolgendeVrijeIndex] = film;
                    eerstVolgendeVrijeIndex++;
                }
            }

            return terugTeGevenFilms;
        }

        public void OntleenFilm(Film film)
        {
            // Als de film nog niet in een rek zit kan je hem niet ontlenen
            if (film.Rek == null)
            {
                Console.WriteLine($"{film.ToString()}\n\tzit nog niet in een rek.");
                return;
            }

            // Als de film al ontleent is kan je hem niet meer ontlenen
            if (film.IsOntleent)
            {
                Console.WriteLine($"{film.ToString()}\n\tis al ontleent.");
                return;
            }

            film.IsOntleent = true;
            Console.WriteLine($"{film.ToString()}\n\tSuccesvol ontleent.");
        }

        public void BrengFilmBinnen(Film film)
        {
            // Als de film nog niet aan een rek is toegewezen kan je hem niet binnenbrengen
            if (film.Rek == null)
            {
                Console.WriteLine($"{film.ToString()}\n\tzit nog niet in een rek.");
                return;
            }

            // Als de film nog nog niet ontleent is kan je hem niet binnenbrengen
            if (!film.IsOntleent)
            {
                Console.WriteLine($"De film {film.ToString()}\n\tKan niet binnengebracht worden, Hij is al binnengebracht");
                return;
            }

            film.IsOntleent = false;
            Console.WriteLine($"{film.ToString()}\n\tSuccesvol binnengebracht.");
        }

        public void VoegFilmToeAanVideoTheek(Film film, Rek rek)
        {
            // Als de kast waar een rek inzit niet overeenkomt met het genre van de film
            // kan je hem niet toevoegen
            if(!Equals(film.Genre, rek.Kast.Genre))
            {
                Console.WriteLine($"Het genre van de film en kast komen niet overeen");
                return;
            }

            film.Rek = rek;
            VoegFilmToeAanVideoTheek(film);

            if (!rek.VoegFilmToeAanRek(film))
                return;

            Console.WriteLine($"Succesvol toegevoegd: {film.ToString()}");
        }

        private void VoegFilmToeAanVideoTheek(Film film)
        {
            // controleer als de film al in de lijst zit, zoja ga uit de method
            for(int i = 0; i < volgendeVrijeIndexVoorFilms; i++)
            {
                Film checkFilm = Films[i];

                if (checkFilm.Equals(film))
                {
                    return;
                }
            }

            Films[volgendeVrijeIndexVoorFilms] = film;
            volgendeVrijeIndexVoorFilms++;
        }

        public void PrintAlleFilms()
        {
            foreach(Kast kast in Kasten)
            {
                kast.Printkast();
                Console.WriteLine();
            }
        }
    }
}
