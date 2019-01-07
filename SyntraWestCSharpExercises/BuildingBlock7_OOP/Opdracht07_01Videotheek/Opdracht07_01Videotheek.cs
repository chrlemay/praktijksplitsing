using System;

namespace SyntraWestCSharpExercises.BuildingBlock7_OOP.Opdracht07_01Videotheek
{
    public class Opdracht07_01Videotheek : ExerciseBase
    {
        public override void RunExercise()
        {
            // Fill DataSet
            Genre fantasy = new Genre("Fantasy");
            Genre sciFi = new Genre("Sci-Fi");
            Genre horror = new Genre("Horror");

            Rek rek1KastFantasy = new Rek();
            Rek rek2KastFantasy = new Rek();
            Rek rek1KastSciFi = new Rek();
            Rek rek2KastSciFi = new Rek();
            Rek rek1KastHorror = new Rek();
            Rek rek2KastHorror = new Rek();

            Rek[] rekkenFantasy = { rek1KastFantasy, rek2KastFantasy };
            Rek[] rekkenSciFi = { rek1KastSciFi, rek2KastSciFi };
            Rek[] rekkenHorror = { rek1KastHorror, rek2KastHorror };

            Kast kastFantasy = new Kast(fantasy, rekkenFantasy);
            Kast kastSciFi = new Kast(sciFi, rekkenSciFi);
            Kast kastHorror = new Kast(horror, rekkenHorror);

            rek1KastFantasy.Kast = kastFantasy;
            rek2KastFantasy.Kast = kastFantasy;
            rek1KastSciFi.Kast = kastSciFi;
            rek2KastSciFi.Kast = kastSciFi;
            rek1KastHorror.Kast = kastHorror;
            rek2KastHorror.Kast = kastHorror;

            Film fantasticBeast = new Film("Fantastic Beasts: The Crimes of Grindewald","David Yates", fantasy);
            Film fantasticBeast2 = new Film("Fantastic Beasts: The Crimes of Grindewald", "David Yates", fantasy);
            Film wrinkelTime = new Film("A Wrinkle In Time", "Ava DuVernay", fantasy);
            Film nutCracker = new Film("The Nutcracker", "Lassa hallstorm", fantasy);

            Film solo = new Film("Solo: A Star Wars Story", "Ron Howard", sciFi);
            Film annihilation = new Film("Annihilation", "Alex Garland", sciFi);
            Film readyPlayerOne = new Film("Ready Player One", "Steven Spielberg", sciFi);
            Film ai = new Film("A.I. Artificial Intelligence", "Steven Spielberg", sciFi);

            Film halloween = new Film("halloween", "David Gordon Green", horror);
            Film quietPlace = new Film("A Quiet Place", "john Krasinksi", horror);
            Film hereditary = new Film("Hereditary", "Ari Aster", horror);
            Film nun = new Film("The Nun", "Corin Hardy", horror);

            Kast[] kasten = { kastFantasy, kastSciFi, kastHorror };

            Videotheek videotheek = new Videotheek(kasten);
            
            // Do some action
            videotheek.BrengFilmBinnen(solo);
            videotheek.OntleenFilm(halloween);
            Console.WriteLine();

            videotheek.VoegFilmToeAanVideoTheek(fantasticBeast, rek1KastHorror);
            Console.WriteLine();

            videotheek.VoegFilmToeAanVideoTheek(fantasticBeast, rek1KastFantasy);
            videotheek.VoegFilmToeAanVideoTheek(fantasticBeast2, rek1KastFantasy);
            videotheek.VoegFilmToeAanVideoTheek(wrinkelTime, rek1KastFantasy);
            videotheek.VoegFilmToeAanVideoTheek(nutCracker, rek1KastFantasy);
            videotheek.VoegFilmToeAanVideoTheek(nutCracker, rek2KastFantasy);
            Console.WriteLine();

            videotheek.VoegFilmToeAanVideoTheek(solo, rek1KastSciFi);
            videotheek.VoegFilmToeAanVideoTheek(annihilation, rek1KastSciFi);
            videotheek.VoegFilmToeAanVideoTheek(ai, rek2KastSciFi);
            videotheek.VoegFilmToeAanVideoTheek(readyPlayerOne, rek2KastSciFi);
            Console.WriteLine();

            videotheek.VoegFilmToeAanVideoTheek(halloween, rek2KastHorror);
            videotheek.VoegFilmToeAanVideoTheek(quietPlace, rek2KastHorror);
            videotheek.VoegFilmToeAanVideoTheek(hereditary, rek2KastHorror);
            videotheek.VoegFilmToeAanVideoTheek(nun, rek1KastHorror);
            Console.WriteLine();

            videotheek.PrintAlleFilms();
            Console.WriteLine();

            videotheek.BrengFilmBinnen(solo);
            videotheek.OntleenFilm(halloween);
            videotheek.OntleenFilm(halloween);
            Console.WriteLine();

            Film[] filmsMetTitel = videotheek.ZoekFilmOpTitel("Fantastic Beasts: The Crimes of Grindewald");
            Console.WriteLine("Films met titel 'Fantastic Beasts: The Crimes of Grindewald'");
            foreach(Film film in filmsMetTitel)
            {
                if(film == null)
                {
                    break;
                }

                Console.WriteLine($"\t-{film.ToString()}");
            }

            Film[] filmsMetRegisseur = videotheek.ZoekFilmOpRegisseur("Steven Spielberg");
            Console.WriteLine("Films met regisseurs 'Steven Spielberg'");
            foreach (Film film in filmsMetRegisseur)
            {
                if(film == null)
                {
                    break;
                }

                Console.WriteLine($"\t-{film.ToString()}");
            }

            Console.WriteLine();

            videotheek.PrintAlleFilms();
        }
    }
}
