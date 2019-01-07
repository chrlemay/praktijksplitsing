using System;

namespace SyntraWestCSharpExercises.BuildingBlock7_OOP.Voorbeeld07_00Boeken
{
    public class Boek
    {
        public Boek(string titel, string auteur, int bladzijden)
        {
            this.Titel = titel;
            this.Auteur = auteur;
            this.Bladzijden = bladzijden;
            this.geplaatsInRek = false;
        }

        private string titel;

        public string Titel
        {
            get
            {
                return titel;
            }

            set
            {
                titel = value;
            }
        }

        private string auteur;

        public string Auteur
        {
            get
            {
                return auteur;
            }

            set
            {
                auteur = value;
            }
        }

        private int bladzijden;

        public int Bladzijden
        {
            get
            {
                return bladzijden;
            }

            set
            {
                if(value < 1)
                {
                    Console.WriteLine("INFO: het aantal bladzijden van een boek moet groter zijn dan nul.");
                }
                else
                {
                    bladzijden = value;
                }
            }
        }

        private bool geplaatsInRek;

        public bool GeplaatsInRek
        {
            get { return geplaatsInRek; }
            set { geplaatsInRek = value; }
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj.GetType() != this.GetType())
                return false;

            Boek anderBoek = obj as Boek;

            return this.Titel == anderBoek.Titel &&
                   this.Auteur == anderBoek.Auteur;
        }

        public override int GetHashCode()
        {
            return this.Titel.Length + this.Auteur.Length;
        }

        public override string ToString()
        {
            return $"Titel: {this.Titel}, Auteur: {this.Auteur}";
        }
    }
}
