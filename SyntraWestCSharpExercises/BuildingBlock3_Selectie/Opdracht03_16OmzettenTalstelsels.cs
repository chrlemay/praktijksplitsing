using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_16OmzettenTalstelsels : ExerciseBase
    {
        public override void RunExercise()
        {
            int keuze = 0;
            string hex = "";
            string decimaal = "";
            string input = "";
            string binair = "";
            string van = "";
            string naar = "";

            Console.WriteLine("");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Maak uw keuze voor omzetting:");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1. Binair naar Hexadecimaal");
            Console.WriteLine("2. Binair naar Decimaal");
            Console.WriteLine("3. Decimaal naar Hexadecimaal");
            Console.WriteLine("4. Decimaal naar Binair");
            Console.WriteLine("5. Hexadecimaal naar Decimaal");
            Console.WriteLine("6. Hexadecimaal naar Binair");
            Console.WriteLine("");

            keuze = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef een getal in:");
            input = Console.ReadLine();
            
            // Naar decimaal
            switch (keuze)
            {
                case 1:         // Van Binair
                case 2:
                    van = "Binair";
                    switch (input)
                    {
                        case "0000":
                            decimaal = "0";
                            break;
                        case "0001":
                            decimaal = "1";
                            break;
                        case "0010":
                            decimaal = "2";
                            break;
                        case "0011":
                            decimaal = "3";
                            break;
                        case "0100":
                            decimaal = "4";
                            break;
                        case "0101":
                            decimaal = "5";
                            break;
                        case "0110":
                            decimaal = "6";
                            break;
                        case "0111":
                            decimaal = "7";
                            break;
                        case "1000":
                            decimaal = "8";
                            break;
                        case "1001":
                            decimaal = "9";
                            break;
                        case "1010":
                            decimaal = "10";
                            break;
                        case "1011":
                            decimaal = "11";
                            break;
                        case "1100":
                            decimaal = "12";
                            break;
                        case "1101":
                            decimaal = "13";
                            break;
                        case "1110":
                            decimaal = "14";
                            break;
                        case "1111":
                            decimaal = "15";
                            break;
                        default:
                            decimaal = "Fout";
                            break;
                    }
                    break;
                case 3:         // Van Decimaal
                case 4:
                    van = "Decimaal";
                    decimaal = input;
                    break;
                case 5:         // Van Hexadecimaal
                case 6:
                    van = "hexadecimaal";
                    switch (input)
                    {
                        case "0":
                            decimaal = "0";
                            break;
                        case "1":
                            decimaal = "1";
                            break;
                        case "2":
                            decimaal = "2";
                            break;
                        case "3":
                            decimaal = "3";
                            break;
                        case "4":
                            decimaal = "4";
                            break;
                        case "5":
                            decimaal = "5";
                            break;
                        case "6":
                            decimaal = "6";
                            break;
                        case "7":
                            decimaal = "7";
                            break;
                        case "8":
                            decimaal = "8";
                            break;
                        case "9":
                            decimaal = "9";
                            break;
                        case "A":
                            decimaal = "10";
                            break;
                        case "B":
                            decimaal = "11";
                            break;
                        case "C":
                            decimaal = "12";
                            break;
                        case "D":
                            decimaal = "13";
                            break;
                        case "E":
                            decimaal = "14";
                            break;
                        case "F":
                            decimaal = "15";
                            break;
                        default:
                            decimaal = "Fout";
                            break;
                    }
                    break;
            }

            // Van Decimaal
            switch (keuze)
            {
                case 1:         // Naar Hexadecimaal
                case 3:
                    naar = "Hexadecimaal";
                    switch (decimaal)
                    {
                        case "0":
                            hex = "0";
                            break;
                        case "1":
                            hex = "1";
                            break;
                        case "2":
                            hex = "2";
                            break;
                        case "3":
                            hex = "3";
                            break;
                        case "4":
                            hex = "4";
                            break;
                        case "5":
                            hex = "5";
                            break;
                        case "6":
                            hex = "6";
                            break;
                        case "7":
                            hex = "7";
                            break;
                        case "8":
                            hex = "8";
                            break;
                        case "9":
                            hex = "9";
                            break;
                        case "10":
                            hex = "A";
                            break;
                        case "11":
                            hex = "B";
                            break;
                        case "12":
                            hex = "C";
                            break;
                        case "13":
                            hex = "D";
                            break;
                        case "14":
                            hex = "E";
                            break;
                        case "15":
                            hex = "F";
                            break;
                        default:
                            hex = "Fout";
                            break;
                    }
                    break;
                case 2:         // Naar Decimaal
                case 5:
                    naar = "Decimaal";
                    break;
                case 4:         // Naar Binair
                case 6:
                    naar = "Binair";
                    switch (decimaal)
                    {
                        case "0":
                            binair = "0000";
                            break;
                        case "1":
                            binair = "0001";
                            break;
                        case "2":
                            binair = "0010";
                            break;
                        case "3":
                            binair = "0011";
                            break;
                        case "4":
                            binair = "0100";
                            break;
                        case "5":
                            binair = "0101";
                            break;
                        case "6":
                            binair = "0110";
                            break;
                        case "7":
                            binair = "0111";
                            break;
                        case "8":
                            binair = "1000";
                            break;
                        case "9":
                            binair = "1001";
                            break;
                        case "10":
                            binair = "1010";
                            break;
                        case "11":
                            binair = "1011";
                            break;
                        case "12":
                            binair = "1100";
                            break;
                        case "13":
                            binair = "1101";
                            break;
                        case "14":
                            binair = "1110";
                            break;
                        case "15":
                            binair = "1111";
                            break;
                        default:
                            binair = "Fout";
                            break;
                    }
                    break;
                default:
                    hex = "Foute ingave";
                    break;
            }

            Console.WriteLine();
            Console.WriteLine($"Je hebt gekozen voor een omzetting van {van} naar {naar}");
            Console.WriteLine($"De waarde dat je wilt omzetten is {input}");

            switch (naar)
            {
                case "Hexadecimaal":
                    Console.WriteLine($"De omgezette waarde is {hex}");
                    break;
                case "Decimaal":
                    Console.WriteLine($"De omgezette waarde is {decimaal}");
                    break;
                case "Binair":
                    Console.WriteLine($"De omgezette waarde is {binair}");
                    break;
                default:
                    Console.WriteLine("Fout bij de omzetiing");
                    break;
            }
        }
    }
}
