using System;

namespace SyntraWestCSharpExercises.BuildingBlock6_IntroOOP.Opdracht06_01Kerstmis
{
    public class Fabriek
    {
        private Fee fee1;

        private Fee fee2;

        private Speelgoed[] kast;

        public Fabriek(Fee fee1, Fee fee2, int kastGrootte)
        {
            this.fee1 = fee1;
            this.fee2 = fee2;
            this.kast = new Speelgoed[kastGrootte];

            for (int i = 0; i < kastGrootte; i++)
            {
                kast[i] = new Speelgoed();
            }
        }

        public Fee GetFee1()
        {
            return this.fee1;
        }

        public Fee GetFee2()
        {
            return this.fee2;
        }

        public Speelgoed[] GetSpeelgoed()
        {
            return this.kast;
        }

        public decimal TotaleKost()
        {
            return this.fee1.VerdiendBedrag() + this.fee2.VerdiendBedrag();
        }

        private void PrintGemaaktSpeelgoed()
        {
            Console.WriteLine("Status Gemaakte Speelgoed");
            Console.WriteLine("------------------------------\n");

            foreach (var sg in this.kast)
            {
                if (sg.GetIsGemaakt())
                {
                    Console.WriteLine(sg.ToString());
                }
            }
        }

        private void PrintIngepaktSpeelgoed()
        {
            Console.WriteLine("Status Ingepakte Speelgoed");
            Console.WriteLine("-------------------------------\n");

            foreach (var sg in this.kast)
            {
                if (sg.GetIsIngepakt())
                {
                    Console.WriteLine(sg.ToString());
                }
            }
        }

        private void PrintOnafgewerktSpeelgoed()
        {
            Console.WriteLine("Status Onafgewerkt Speelgoed");
            Console.WriteLine("----------------------------\n");

            foreach (var sg in this.kast)
            {
                if (!sg.GetIsIngepakt() && !sg.GetIsGemaakt())
                {
                    Console.WriteLine(sg.ToString());
                }
            }
        }

        public void PrintRaportFabriek()
        {
            Console.WriteLine("|--------------|");
            Console.WriteLine("|RAPORT FABRIEK|");
            Console.WriteLine("|--------------|");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----");
            Console.WriteLine("Feeën");
            Console.WriteLine("-----");
            Console.WriteLine();
            Console.WriteLine($"{this.fee1.GetVolledigeNaam()} de {this.fee1.GetJob().GetNaam()} " +
                $"verdiend {this.fee1.VerdiendBedrag()}");
            Console.WriteLine($"{this.fee2.GetVolledigeNaam()} de {this.fee2.GetJob().GetNaam()} " +
               $"verdiend {this.fee2.VerdiendBedrag()}");

            Console.WriteLine("---------");
            Console.WriteLine("speelgoed");
            Console.WriteLine("---------");
            Console.WriteLine();
            PrintOnafgewerktSpeelgoed();
            Console.WriteLine();
            PrintGemaaktSpeelgoed();
            Console.WriteLine();
            PrintIngepaktSpeelgoed();
        }
    }
}
