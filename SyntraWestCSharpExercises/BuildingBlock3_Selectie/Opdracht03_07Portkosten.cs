using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_07Portkosten : ExerciseBase
    {
        public override void RunExercise()
        {
            string binnenBelgie, genormaliseerd;
            float gewicht, bedrag;

            Console.WriteLine("Versturen binnen België (y/n)");
            binnenBelgie = Console.ReadLine();

            Console.WriteLine("Genormaliseerd (y/n)");
            genormaliseerd = Console.ReadLine();

            Console.WriteLine("Hoeveel weegt je pakje:");
            gewicht = float.Parse(Console.ReadLine());

            if(binnenBelgie == "y")
            {
                if(genormaliseerd == "y")
                {
                    if(gewicht > 50)
                    {
                        bedrag = -1;
                    }
                    else
                    {
                        bedrag = .7f;
                    }
                }
                else
                {
                    if(gewicht <= 100)
                    {
                        bedrag = 1.4f;
                    }
                    else if(gewicht <= 350)
                    {
                        bedrag = 2.1f;
                    }
                    else if(gewicht <= 1000)
                    {
                        bedrag = 3.5f;
                    }
                    else if(gewicht <=2000)
                    {
                        bedrag = 4.9f;
                    }
                    else
                    {
                        bedrag = -1;
                    }
                }
            }
            else
            {
                if (genormaliseerd == "y")
                {
                    if (gewicht > 50)
                    {
                        bedrag = -1;
                    }
                    else
                    {
                        bedrag = 1.07f;
                    }
                }
                else
                {
                    if (gewicht <= 100)
                    {
                        bedrag = 3.21f;
                    }
                    else if (gewicht <= 350)
                    {
                        bedrag = 6.42f;
                    }
                    else if (gewicht <= 1000)
                    {
                        bedrag = 10.7f;
                    }
                    else if (gewicht <= 2000)
                    {
                        bedrag = 21.4f;
                    }
                    else
                    {
                        bedrag = -1;
                    }
                }
            }

            Console.WriteLine($"Binnen België {(binnenBelgie == "y" ? "Ja" : "Nee")}");
            Console.WriteLine($"Genormaliseerd {(genormaliseerd == "y" ? "Ja" : "Nee")}");
            Console.WriteLine($"Gewicht {gewicht}");
            Console.WriteLine($"te betalen: {bedrag}");
        }
    }
}
