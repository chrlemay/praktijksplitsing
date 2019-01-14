using System;
using System.Collections.Generic;
using System.Text;

namespace SyntraWestCSharpExercises.BuildingBlock8_Methods
{
    class Bereken
    {
        List<double> GetalReeks = new List<double>();
        double Getal1 = 0;
        double Getal2 = 0;

        public Bereken(double getal1, double getal2)
        {
            Getal1 = getal1;
            Getal2 = getal2;
        }

        public double Optellen(double getal1, double getal2)
        {
            double som = getal1 + getal2;
            Console.WriteLine(+getal1 + " +  " + getal2 + " =" + (getal1 + getal2));
            return som;
        }
        public double Aftrekken(double getal1, double getal2)
        {
            double verschil = getal1 - getal2;
            Console.WriteLine(+getal1 + "  -  " + getal2 + " =" + (getal1 - getal2));
            return verschil;
        }



        public double Vermenigvuldigen(double getal1, double getal2)
        {
            double product = getal1 * getal2;
            Console.WriteLine(+getal1 + " X " + getal2 + " =" + (getal1 * getal2));
            return product;
        }
        public double Delen(double getal1, double getal2)
        {
            double qoutient = getal1 / getal2;
            Console.WriteLine(+getal1 + " / " + getal2 + " =" + (getal1 / getal2));
            return qoutient;
        }
        public double Macht(double getal1, double getal2)
        {
            double machtvan = getal1 * getal2;
            Console.WriteLine(+getal2 + "de macht van  " + getal1 + " =" + ( (double)Math.Pow(getal1, getal2)));
            return machtvan;
        }


        internal static void TrekLijn(string lijn, char ch)
        { int ll = lijn.Length;
            // Console.Write(" ");
            for (int i = 0; i < ll+2 ; i++)
            {
                Console.Write(ch);
            }
            Console.WriteLine(" ");
        }
        /*
        public double Ingeven(double getal)
        {
            Console.WriteLine(" geef getal  1 in: ");
             getal = double.Parse(Console.ReadLine());
            return getal;
                
        }
        */

    }

}

