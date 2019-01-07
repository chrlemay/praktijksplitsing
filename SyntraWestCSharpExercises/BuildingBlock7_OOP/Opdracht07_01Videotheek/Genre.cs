using System;

namespace SyntraWestCSharpExercises.BuildingBlock7_OOP.Opdracht07_01Videotheek
{
    public class Genre
    {
        public string Naam { get; set; }

        public Genre(string naam)
        {
            this.Naam = naam;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj.GetType() != this.GetType())
                return false;

            Genre anderGenre = obj as Genre;

            return this.Naam == anderGenre.Naam;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Naam);
        }
    }
}
