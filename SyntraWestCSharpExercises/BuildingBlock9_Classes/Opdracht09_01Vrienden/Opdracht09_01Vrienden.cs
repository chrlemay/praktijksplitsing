using SyntraWestCSharpExercises.BuildingBlock9_Classes.Opdracht09_01Vrienden;
using System;
namespace SyntraWestCSharpExercises.BuildingBlock9_Classes.Opdracht09_03Vrienden
{
    public class Opdracht09_01Vrienden : ExerciseBase
    {
        public override void RunExercise()   //  dit is method die de Main aanroept 
        {
            Console.WriteLine($" geef de naam van de persoon :");
            string persoon = Console.ReadLine();
            Persoon mijnPersoon = new Persoon(persoon);      // variable aanmaken "mijnPersoon" van type "Persoon"  
                                                             // geeft variable "Persoon" terug met waarde "persoon" (die werdt meegegeven)
            Console.WriteLine($" geef de naam van de vriend :");
            string vriend = Console.ReadLine();
            mijnPersoon.VerwelkomVriend(vriend);            // variable 'mijnPersoon' roept methode 'VerwelkomVriend' aan, met de waarde 'vriend' als argument

            Console.WriteLine($" geef de naam van de vertrekkende vriend :");
            vriend = Console.ReadLine();
            mijnPersoon.ZwaaiVriendUit(vriend);            // variable 'mijnPersoon' roept methode 'ZwaaitZijnVriendUit' aan, met de waarde 'vriend' als argument
        }
    }
}