using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_08MultipleChoice : ExerciseBase
    {
        public override void RunExercise()
        {
            string antwoord = " ";
            Console.WriteLine("Wat is de juist manier om een variabele op te slaan in een integer waarde?");
            Console.WriteLine("\t a. int 1x=10");
            Console.WriteLine("\t b. int x=10");
            Console.WriteLine("\t c. float x=10.0f");
            Console.WriteLine("\t d. string x=\"10\"");

            Console.Write("Geef je keuze in :");
            antwoord = Console.ReadLine();
            
            switch (antwoord)
            {
                case "a":
                    Console.WriteLine("Foutief!");
                    break;
                case "b":
                    Console.WriteLine("Correct!");
                    break;
                case "c":
                    Console.WriteLine("Foutief!");
                    break;
                case "d":
                    Console.WriteLine("Foutief!");
                    break;
                default:
                    Console.WriteLine("niet ingegeven!");
                    break;
            }

        }
    }
}
