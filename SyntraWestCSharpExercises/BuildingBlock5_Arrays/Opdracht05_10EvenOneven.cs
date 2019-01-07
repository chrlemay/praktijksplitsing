using System;
using System.Collections.Generic;
using System.Text;

namespace SyntraWestCSharpExercises.BuildingBlock5_Arrays
{
    public class Opdracht05_10EvenOneven : ExerciseBase
    {
        public override void RunExercise()
        {
            Random random = new Random();
            int aantal = 20;

            int[] getallen = new int[aantal]; 
            int[] even = new int[aantal];  
            int[] oneven = new int[aantal];     
            int tellerEven = 0;                 
            int tellerOneven = 0;               
            
            for (int i = 0; i < aantal; i++)
            {
                getallen[i] = random.Next(0, 31);
            }

            // Kopieren naar correcte array
            for (int i = 0; i < aantal; i++)
            {
                if (getallen[i] % 2 == 0)   // even getal
                {
                    even[tellerEven] = getallen[i];
                    tellerEven++;
                }
                else                        // oneven getal
                {
                    oneven[tellerOneven] = getallen[i];
                    tellerOneven++;
                }
            }

            // Vul de lege entries aan met -99
            if (tellerEven < aantal)
            {
                even[tellerEven] = -99;
            }

            if (tellerOneven < aantal)
            {
                oneven[tellerOneven] = -99;
            }

            // Output
            // Alle getallen
            for (int i = 0; i < aantal; i++)
            {
                Console.Write(getallen[i] + " - ");
            }

            // uitvoer van alle even getallen
            Console.WriteLine();
            Console.Write("Even: ");

            for (int i = 0; even[i] != -99 && i < aantal; i++)
            {
                Console.Write(even[i] + " - ");
            }

            // uitvoer van alle oneven getallen
            Console.WriteLine();
            Console.Write("Oneven: ");

            for (int i = 0; oneven[i] != -99 && i < aantal; i++)
            {
                Console.Write(oneven[i] + " - ");
            }

        }
    }
}
