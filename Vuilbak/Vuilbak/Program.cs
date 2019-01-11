using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuilbak
{
    class Program
    {
        static void Main(string[] args)
        {
            string stop = "";
            Console.WriteLine(" hoeveel stukken passen in de vuilbak :");
            int grootteVuilbak = int.Parse(Console.ReadLine());
            Vuilbak nieuweVuilbak = new Vuilbak(grootteVuilbak);

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
