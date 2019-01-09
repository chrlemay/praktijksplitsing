using System;
using System.Collections.Generic;
using System.Text;

namespace SyntraWestCSharpExercises.BuildingBlock9_Classes.Opdracht09_01Vrienden
{
    class Persoon
    {
        
        public string Naam { get; set; }            // properties eigenschappen gedefineerd als Naam 
        public Persoon(string naam)                 // constructor 'Persoon' met één parameter type 'string'en als naam ='naam'
        {                                           // Naam wordt gelijk de waarde van de parameter gegeven 
             Naam = naam;
        }
         
       public void ZwaaiVriendUit(String vriend)   // Methode 'ZwaaitVriendUit'
       {                                            //signature 'public' kan aangeroepen worden van uit andere classes ( andere signature static, private, protected enz..)
                                                   //signature ook access modifiers, scope, of protection levels genoemd
                                                   //type 'void' (retourneerd niets)
                                                   // functienaam 'Zwaaitvrienduit' 
                                                   // parameteredeclaratie 'Type  = string', naam = 'vriend'
        
            Console.WriteLine($" { Naam } zwaait zijn vriend { vriend } uit.");
        }

        public void VerwelkomVriend(string vriend)
        {
            Console.WriteLine($"{Naam } verwelkomt zijn vriend {vriend}." );
        }

       
    }
}
