using System;
using System.Collections.Generic;
using System.Text;

namespace SyntraWestCSharpExercises.BuildingBlock6_IntroOOP.Opdracht06_00Facturen
{
    public class Btw
    {
        private decimal percentage;

        public Btw(decimal percentage)
        {
            this.percentage = percentage;
        }

        public decimal GetPercentage()
        {
            return this.percentage;
        }
    }
}
