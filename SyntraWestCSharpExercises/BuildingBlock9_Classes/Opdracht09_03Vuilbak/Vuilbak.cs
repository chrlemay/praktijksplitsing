using System;
using System.Collections.Generic;

namespace SyntraWestCSharpExercises.BuildingBlock9_Classes.Opdracht09_03Vuilbak
{
    class Vuilbak
    {
        List<string> InhoudVuilbak = new List<string>();
        int i = 0;
        int vuil = 0;
        int GrootteVuilbak = 0;
        string vuilnis = "";
        //string lijn = ""

        public Vuilbak(int grootteVuilbak)
        {
            GrootteVuilbak = grootteVuilbak;
        }

        /* public Vuilbak(int grootteVuilbak)
         {
             GrootteVuilbak = grootteVuilbak;
         }*/

        public void WerpVuilnis()
        {

            Console.WriteLine($" wat smijt je in de vuilbak ? :");

            vuilnis = Console.ReadLine();
            char ch = '^';
            Treklijn(vuilnis, ch);

            if (i == GrootteVuilbak)
            {
                Console.WriteLine($" je hebt reeds { GrootteVuilbak } stukken in de vuilnisbak,  nu is die vol, leegdig  eerst de vuilbak \n\n");

            }
            else
            {
                i++;
                InhoudVuilbak.Add(vuilnis);
                Console.WriteLine($"{ vuilnis } is weggesmeten \n ");
                ch = '=';
                Treklijn(vuilnis, ch);

            }

        }



        public void LeegVuilnis()
        {
            foreach (string vuilnis in InhoudVuilbak)
            {
                vuil++;
                Console.WriteLine($" {vuilnis} is uitgekieperd \n");

            }

            Console.WriteLine("" + vuil + " stukken vuil werden geleegd");
            char ch = '*';
            string lijn = "                            ";
            Treklijn(lijn, ch);
        }

        public void Treklijn(string lijn, char ch)
        
        {
            int ll = lijn.Length;
            // Console.Write(" ");
            for (int i = 0; i < ll + 2; i++)
            {
                Console.Write(ch);
            }
            Console.WriteLine(" ");
        }

    }
}
