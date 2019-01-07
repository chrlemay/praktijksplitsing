using System;

namespace SyntraWestCSharpExercises.BuildingBlock3_Selectie
{
    public class Opdracht03_22Examen : ExerciseBase
    {
        public override void RunExercise()
        {
            float puntenWiskunde = 0;
            float puntenBoekhouden = 0;
            float puntenInformatica = 0;
            float som = 0;

            Console.WriteLine("Geef de punten voor Wiskunde:");
            puntenWiskunde = float.Parse(Console.ReadLine());

            Console.WriteLine("Geef de punten voor Boekhouden:");
            puntenBoekhouden = float.Parse(Console.ReadLine());

            Console.WriteLine("Geef de punten voor Informatica:");
            puntenInformatica = float.Parse(Console.ReadLine());

            som = puntenBoekhouden + puntenInformatica;

            if ((puntenWiskunde >= 6) && (som >= 12))
            {
                Console.WriteLine("Geslaagd!");
            }
            else
            {
                if (puntenWiskunde < 6)
                {
                    Console.WriteLine("Niet geslaagd, want onvoldoende voor Wiskunde!");
                }

                if (som < 12)
                {
                    Console.WriteLine("Niet geslaagd, want onvoldoende voor Boekhouden en Informatica");
                }
            }
        }
    }
}
