using System;
namespace SyntraWestCSharpExercises.BuildingBlock9_Classes.Opdracht09_03Vuilbak
{
    public class Opdracht09_03Vuilbak : ExerciseBase
    {
        public override void RunExercise()
        {
            string stop = "";
            Console.WriteLine(" hoeveel stukken passen in de vuilbak :");
            
            int grootteVuilbak = int.Parse(Console.ReadLine());
            Vuilbak nieuweVuilbak = new Vuilbak(grootteVuilbak);

             
            Console.WriteLine($"vuilbak met plaats voor {grootteVuilbak} is aangemaakt ");

            
            while (stop != "stop")
            {
                Console.WriteLine(" 1. vuil weggooien \n 2. vuilbak leeg maken \n 3. stop ");
                Console.WriteLine("Wat moetje uitvoeren 1 of 2 : ");    
                int antwoord = int.Parse(Console.ReadLine());     

                switch (antwoord)
                {
                    case 1:
                        nieuweVuilbak.WerpVuilnis();
                        break;
                    case 2:
                        nieuweVuilbak.LeegVuilnis();
                        break;
                    case 3:
                        stop = "stop";
                        break;
                    default:
                        Console.WriteLine(" ongeldige ingave!");
                        break;

                }




            }
        }
    }
}
