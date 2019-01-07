using System;

namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_03ConvertCelciusToFarenheit : ExerciseBase
    {
        public override void RunExercise()
        {
            float gradenCelcius;
            float gradenFarenheit;

            Console.WriteLine("Geef aantal graden celcius in:");
            gradenCelcius = float.Parse(Console.ReadLine());

            gradenFarenheit = gradenCelcius * 1.8f + 32;

            Console.WriteLine($"Farenheit = {gradenFarenheit}");
        }
    }
}
