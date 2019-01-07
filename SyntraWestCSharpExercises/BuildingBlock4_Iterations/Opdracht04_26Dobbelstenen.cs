using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_26Dobbelstenen : ExerciseBase
    {
        public override void RunExercise()
        {
            decimal inzet;
            decimal uiteindelijkBedrag;
            int getal1;
            int getal2;
            int tweeKeerZes = 0;
            int tweeKeerHetzelfde = 0;
            int aantalKeerZes = 0;
            var dobbelsteen = new Random();

            do
            {
                uiteindelijkBedrag = 0;

                Console.WriteLine("geef je inzet tussen 5 en 100");
                inzet = decimal.Parse(Console.ReadLine());

                Console.WriteLine();

                for (int teller = 0; teller < 3; teller++)
                {
                    getal1 = dobbelsteen.Next(1, 7);
                    getal2 = dobbelsteen.Next(1, 7);

                    Console.WriteLine($"worp {teller + 1}: {getal1} en {getal2}");

                    if (getal1 == 6 || getal2 == 6)
                    {
                        if (getal1 == 6 && getal2 == 6)
                        {
                            tweeKeerZes++;
                        }
                        else
                        {
                            aantalKeerZes++;
                        }
                    }
                    else if (getal1 == getal2)
                    {
                        tweeKeerHetzelfde++;
                    }
                }

                //output
                if (tweeKeerZes >= 1)
                {
                    uiteindelijkBedrag += inzet * 50;
                    Console.WriteLine("bij 1 van de 3 worpen is er 2 keer een 6 geworpen.");
                }
                else if (tweeKeerHetzelfde >= 1)
                {
                    uiteindelijkBedrag += inzet * 10;
                    Console.WriteLine("bij 1 van de 3 worpen is er 2 keer een hetzelfde geworpen.");
                }
                else if (aantalKeerZes == 2)
                {
                    uiteindelijkBedrag += inzet * 2;
                    Console.WriteLine("Bij de 3 worpen is er 2 keer een zes geworpen.");
                }

                Console.WriteLine($"Je krijgt {uiteindelijkBedrag} terug");

                Console.WriteLine("als je nog eens wilt spelen geef 1 in");
            }
            while (Console.ReadLine() == "1");
        }
    }
}
