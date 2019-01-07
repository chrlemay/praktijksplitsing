using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_28Examens : ExerciseBase
    {
        public override void RunExercise()
        {
            float puntenWiskunde = 0;
            float puntenInformatica = 0;
            float puntenBoekhouden = 0;

            // Punten Wiskunde
            do
            {
                Console.WriteLine("Geef Punten voor Wiskunde (0-10): ");
                puntenWiskunde = float.Parse(Console.ReadLine());
            }
            while (puntenWiskunde < 0 || puntenWiskunde > 10);

            if (puntenWiskunde < 6)
            {
                Console.WriteLine("Niet geslaagd: Te weinig voor Wiskunde.");
                return;
            }

            // Punten Informatica
            do
            {
                Console.WriteLine("Geef Punten voor Informatica (0-10): ");
                puntenInformatica = float.Parse(Console.ReadLine());
            }
            while (puntenInformatica < 0 || puntenInformatica > 10);

            // Punten Boekhouden
            do
            {
                Console.WriteLine("Geef Punten voor Boekhouden (0-10): ");
                puntenBoekhouden = float.Parse(Console.ReadLine());
            }
            while (puntenBoekhouden < 0 || puntenBoekhouden > 10);

            if (puntenBoekhouden + puntenInformatica > 12)
            {
                Console.WriteLine("Geslaagd");
            }
            else
            {
                Console.WriteLine("Niet geslaagd: Te weinig voor Boekhouden en Informatica");
            }
        }        
    }
}
