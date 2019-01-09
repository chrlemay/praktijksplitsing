using System;
using System.Collections.Generic;

namespace SyntraWestCSharpExercises.BuildingBlock9_Classes.Opdracht09_02Dagboek
{
    class Opdracht09_02Dagboek : ExerciseBase
    {
        public override void RunExercise()
        {
            
            Console.WriteLine($" geef de naam van het dagboek : ");
            string dagboekNaam = Console.ReadLine();
            Dagboek mijnDagboek = new Dagboek(dagboekNaam);

            mijnDagboek.SchrijfNieuwePagina();


            mijnDagboek.PrintBoek();


        }
    }
}
