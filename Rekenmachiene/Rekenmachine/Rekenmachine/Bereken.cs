using System;
using System.Collections.Generic;
using System.Text;

namespace Rekenmachine
{
    class Bereken
    {

        //List<double> GetalReeks = new List<double>();
        // double Getal1 = 0;
        // double Getal2 = 0;

        public Bereken()   //(double getal1, double getal2)
        {
            // Getal1 = getal1;
            // Getal2 = getal2;
        }

        public double Optellen(double getal1, double getal2)
        {
            double som = getal1 + getal2;
            Console.WriteLine(+getal1 + " +  " + getal2 + " = " + som);
            return som;
        }
        public double Aftrekken(double getal1, double getal2)
        {
            double verschil = getal1 - getal2;
            Console.WriteLine(+getal1 + "  -  " + getal2 + " = " + verschil);
            return verschil;
        }
        public double Vermenigvuldigen(double getal1, double getal2)
        {
            double product = getal1 * getal2;
            Console.WriteLine(+getal1 + " X " + getal2 + " = " + product);
            return product;
        }
        public double Delen(double getal1, double getal2)
        {
            if (getal2 == 0)
            {
                Console.WriteLine("je mag niet delen door 0");
                return 0;
            }
            else
            {
                double qoutient = getal1 / getal2;
                Console.WriteLine(+getal1 + " / " + getal2 + " = " + qoutient);
                return qoutient;
            }
        }
        public double Machtvan(double getal1, double getal2)
        {
            double machtvan = (double)Math.Pow(getal1, getal2);
            Console.WriteLine(+getal2 + "de macht van  " + getal1 + " = " + machtvan);
            return machtvan;
        }



        internal static void TrekLijn(string lijn, char ch)
        {
            int ll = lijn.Length;
            // Console.Write(" ");
            for (int i = 0; i < ll + 2; i++)
            {
                Console.Write(ch);
            }
            Console.WriteLine(" ");
        }


        public static void ClearScreen()

        {
            Console.WriteLine("Druk op ENTER om verder te gaan");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
