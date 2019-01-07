using System;

namespace SyntraWestCSharpExercises.BuildingBlock2_Operatoren
{
    public class Opdracht02_15Snoepautomaat : ExerciseBase
    {
        public override void RunExercise()
        {
            float teBetalen = 0.42f;
            int teBetalenInCent = (int)(teBetalen * 100);
            int terugTeGevenInCent = 200 - teBetalenInCent;

            Console.WriteLine($"Te betalen : {teBetalen}");
            Console.WriteLine($"Terug te geven : {terugTeGevenInCent / 100f}");

            int stukkenVanEenEuro = terugTeGevenInCent / 100;
            Console.WriteLine($"Stukken van 1 euro : {stukkenVanEenEuro}");

            terugTeGevenInCent -= stukkenVanEenEuro * 100;
            int stukkenVanVijftigCent = terugTeGevenInCent / 50;
            Console.WriteLine($"Stukken van 50 cent : {stukkenVanVijftigCent}");

            terugTeGevenInCent -= stukkenVanVijftigCent * 50;
            int stukkenVanTwintigCent = terugTeGevenInCent / 20;
            Console.WriteLine($"Stukken van 20 cent : {stukkenVanTwintigCent}");

            terugTeGevenInCent -= stukkenVanTwintigCent * 20;
            int stukkenVanTienCent = terugTeGevenInCent / 10;
            Console.WriteLine($"Stukken van 10 cent : {stukkenVanTienCent}");

            terugTeGevenInCent -= stukkenVanTienCent * 10;
            int stukkenVanVijfCent = terugTeGevenInCent / 5;
            Console.WriteLine($"Stukken van 5 cent : {stukkenVanVijfCent}");

            terugTeGevenInCent -= stukkenVanVijfCent * 5;
            int stukkenVanTweeCent = terugTeGevenInCent / 2;
            Console.WriteLine($"Stukken van 2 cent : {stukkenVanTweeCent}");

            terugTeGevenInCent -= stukkenVanTweeCent * 2;
            int stukkenVanEenCent = terugTeGevenInCent;
            Console.WriteLine($"Stukken van 1 cent : {stukkenVanEenCent}");
        }
    }
}
