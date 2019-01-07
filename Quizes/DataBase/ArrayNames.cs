using Quizes.DataBase;
using System.Collections.Generic;

namespace Quizes
{
    public static class ArrayNames
    {
        public static Dictionary<string, List<string>> ArrayNamesPerDataType => new Dictionary<string, List<string>>
        {
            {
                DataTypesR.String, new List<string>
                {
                    ArrayNamesR.Dagen,
                    ArrayNamesR.FilmLijst,
                    ArrayNamesR.Kleuren,
                    ArrayNamesR.Maanden,
                    ArrayNamesR.Namen
                }
            },
            {
                DataTypesR.Char, new List<string>
                {
                    ArrayNamesR.Alfabet,
                    ArrayNamesR.EersteLettersVanNaam
                }
            },
            {
                DataTypesR.Int, new List<string>
                {
                    ArrayNamesR.Beenderen,
                    ArrayNamesR.Leeftijd,
                    ArrayNamesR.RamenPerGebouw,
                    ArrayNamesR.Apples,
                    ArrayNamesR.Bouwjaren,
                    ArrayNamesR.BladzijdenPerBoek,
                    ArrayNamesR.DagenPerMaand
                }
            },
            {
                DataTypesR.Long, new List<string>
                {
                    ArrayNamesR.Beenderen,
                    ArrayNamesR.Leeftijd,
                    ArrayNamesR.RamenPerGebouw,
                    ArrayNamesR.Apples,
                    ArrayNamesR.Bouwjaren,
                    ArrayNamesR.BladzijdenPerBoek,
                    ArrayNamesR.DagenPerMaand
                }
            },
            {
                DataTypesR.Bool, new List<string>
                {
                    ArrayNamesR.AanwezighedenSportClubPerPersoon,
                    ArrayNamesR.AntwoordenOpQuiz
                }
            },
            {
                DataTypesR.Float, new List<string>
                {
                    ArrayNamesR.AfstandenNaarPlaneten,
                    ArrayNamesR.AfstandNaarSteden,
                    ArrayNamesR.DuurFlms,
                    ArrayNamesR.Lengtes,
                    ArrayNamesR.Temperaturen,
                    ArrayNamesR.VolumeKamersHuis
                }
            },
            {
                DataTypesR.Decimal, new List<string>
                {
                    ArrayNamesR.LonenWerknemers,
                    ArrayNamesR.PrijsDrank,
                    ArrayNamesR.Prijzen,
                    ArrayNamesR.PrijzenMenuInRestaurant,
                    ArrayNamesR.waardeEuroPerDag
                }
            }
        };
    }
}
