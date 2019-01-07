using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_14DecimaalNaarBinair : ExerciseBase
    {
        public override void RunExercise()
        {
            int cijfer = 0;
            string bin = "";
            
            Console.WriteLine("Geef een cijfer in (0-8).");
            cijfer = int.Parse(Console.ReadLine());
            
            switch (cijfer)
            {
                case 0:
                    bin = "0000";
                    break;
                case 1:
                    bin = "0001";
                    break;
                case 2:
                    bin = "0010";
                    break;
                case 3:
                    bin = "0011";
                    break;
                case 4:
                    bin = "0100";
                    break;
                case 5:
                    bin = "0101";
                    break;
                case 6:
                    bin = "0110";
                    break;
                case 7:
                    bin = "0111";
                    break;
                case 8:
                    bin = "1000";
                    break;
                default:
                    bin = "Foute ingave";
                    break;
            }

            Console.WriteLine($"Decimaal : {cijfer} - Binair : {bin}");
        }
    }
}
