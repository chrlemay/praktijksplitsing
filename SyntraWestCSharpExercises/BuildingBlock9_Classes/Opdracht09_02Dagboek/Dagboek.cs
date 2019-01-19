using System;
using System.Collections.Generic;

namespace SyntraWestCSharpExercises.BuildingBlock9_Classes.Opdracht09_02Dagboek
{
    class Dagboek
    {
        List<string> boek = new List<string>();
        public string DagboekN { get; set; }             // properties eigenschappen gedefineerd als Dagboek 

        public Dagboek(string dagboekNaam)             // constructor 'Dagboek' met één parameter type 'string'en als naam ='dagboekNaam'
        {
            DagboekN = dagboekNaam;                      // Dagboek wordt gelijk de waarde van de parameter gegeven dagboekNaam
        }

       public void SchrijfNieuwePagina()
        {
             string tekst = "";
            while (tekst != "stop")
            {
                Console.WriteLine($" schrijf een nieuwe pagina voor {DagboekN} :");
                tekst = Console.ReadLine();
                if (tekst != "stop")
                    boek.Add(tekst);
            }
        }
        

        public void PrintBoek()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine($" titel van het boek : \"{DagboekN}\" ");
            int blz = 0;
            int maxBlz = boek.Count;
            foreach (string tekst in boek)
            {
                blz++;
                Console.WriteLine($"Pagina {blz } / { maxBlz} \n {tekst}");
            }

        }
       
    }
}
