using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuilbak
{
    class Vuilbak
    {
        List<string> InhoudVuilbak = new List<string>();
        int i = 0;
        int vuil = 0;
        int GrootteVuilbak = 0;
        string vuilnis = "";
       

        public Vuilbak(int grootteVuilbak)
        {
            GrootteVuilbak = grootteVuilbak;
        }

        public void WerpVuilnis()
        {

            Console.WriteLine($"********************************\n wat smijt je in de vuilbak ? :");
            vuilnis = Console.ReadLine();


            if (i == GrootteVuilbak)
            {
                Console.WriteLine($"****************************************************************************\n je hebt { GrootteVuilbak } stukken in de vuilnisbak,  nu is die vol, leegdig  eerst de vuilbak \n\n");
                
            }
            else
            {
                i++;
                InhoudVuilbak.Add(vuilnis);
                Console.WriteLine($"{ vuilnis } is weggesmeten \n $$$$$$$$$$$$$$$$$$$$$$$$$$$$$ ");
            }

        }

        

        public void LeegVuilnis()
        {
            foreach (string vuilnis in InhoudVuilbak)
            {
                vuil++;
                Console.WriteLine($" {vuilnis} is uitgekieperd \n");
            }
            Console.WriteLine("====================================\n" +vuil + " stukken vuil werden geleegd \n ====================================");
        }




    }
}
