using System;

namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_04ConvertFarenheitToCelcius : ExerciseBase
    {
        public override void RunExercise()
        {
            float gradenFarenheit;
            float gradenCelcius;

            Console.WriteLine("Geef aantal graden Farenheit in:");
            gradenFarenheit = float.Parse(Console.ReadLine());

            gradenCelcius = 5f / 9f * (gradenFarenheit - 32f);

            Console.WriteLine($"Celcius = {gradenCelcius:N2}");
            Console.WriteLine($"Celcius = {(int)gradenCelcius}");
        }
    }
}
