using System;

namespace SyntraWestCSharpExercises.BuildingBlock7_OOP.Opdracht07_01Videotheek
{
    public class Film
    {
        public string Titel { get; set; }
        public string Regisseur { get; set; }
        public Genre Genre { get; set; }
        public bool IsOntleent { get; set; }
        public Rek Rek { get; set; }

        public Film(string titel, string regisseur, Genre genre)
        {
            Titel = titel;
            Regisseur = regisseur;
            Genre = genre;
            IsOntleent = false;
        }

        public override string ToString()
        {
            return $"{Titel}, {Regisseur}, {Genre.Naam}, is ontleent: {IsOntleent}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj.GetType() != this.GetType())
                return false;

            Film andereFilm = obj as Film;

            return this.Titel == andereFilm.Titel && this.Regisseur == andereFilm.Regisseur
                && this.Genre.Equals(andereFilm.Genre);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Titel, Regisseur, Genre, IsOntleent, Rek);
        }
    }
}
