using System;

namespace SyntraWestCSharpExercises.BuildingBlock4_Iterations
{
    public class Opdracht04_27Temperatuur : ExerciseBase
    {
        public override void RunExercise()
        {
            float temperatuur = 0;
            int aantalPositief = 0;
            int aantalNegatief = 0;
            int aantalNul = 0;
            float totaalPositief = 0;
            float totaalNegatief = 0;
            float gemiddeldePositief = 0;
            float gemiddeldeNegatief = 0;

            do
            {
                Console.WriteLine("Geef een temperatuur in (99=stop): ");
                temperatuur = float.Parse(Console.ReadLine());
                
                if (temperatuur != 99)
                {
                    if (temperatuur == 0)
                    {
                        aantalNul++;
                    }
                    else if (temperatuur > 0)
                    {
                        aantalPositief++;
                        totaalPositief += temperatuur;
                    }
                    else    // if(temperatuur<0)
                    {
                        aantalNegatief++;
                        totaalNegatief += temperatuur;
                    }
                }
            }
            while (temperatuur != 99);

            if (aantalPositief == 0)    // Vermijd om te delen door 0
            {
                gemiddeldePositief = 0;
            }
            else
            {
                gemiddeldePositief = totaalPositief / aantalPositief;
            }

            if (aantalNegatief == 0)    // Vermijd om te delen door 0
            {
                gemiddeldeNegatief = 0;
            }
            else
            {
                gemiddeldeNegatief = totaalNegatief / aantalNegatief;
            }

            Console.WriteLine($"Aantal positief     : {aantalPositief}");
            Console.WriteLine($"Aantal negatief     : {aantalNegatief}");
            Console.WriteLine($"Aantal nul          : {aantalNul}");
            Console.WriteLine($"Gemiddelde positief : {gemiddeldePositief}");
            Console.WriteLine($"Gemiddelde negatief : {gemiddeldeNegatief}");
        }
    }
}
