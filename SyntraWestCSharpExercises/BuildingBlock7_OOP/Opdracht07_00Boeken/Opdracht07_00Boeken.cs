using System;

namespace SyntraWestCSharpExercises.BuildingBlock7_OOP.Voorbeeld07_00Boeken
{
    class Opdracht07_00Boeken : ExerciseBase
    {
        public override void RunExercise()
        {
            // Auteurs
            string haruki = "Haruki Murakami";
            string george = "George Orwell";
            string rowling = "J.K. Rowling";

            // BOEKEN 
            Boek kafka = new Boek("Kafka op het strand", haruki, 500);
            Boek Orwell1984 = new Boek("1984", george, 300);
            Boek OrwellAnimalFarm = new Boek("Animal Farm", george, 120);
            Boek HarryPotterGobletFire1 = new Boek("Harry potter and the goblet of fire", rowling, 500);
            Boek HarryPotterGobletFire2 = new Boek("Harry potter and the goblet of fire", rowling, 520);

            // Testing Override methods from the object class
            bool equals = Orwell1984.Equals(OrwellAnimalFarm);
            Console.WriteLine($"{Orwell1984.ToString()}(Hash = {Orwell1984.GetHashCode()})\n" +
                                $"{OrwellAnimalFarm.ToString()}(Hash = {OrwellAnimalFarm.GetHashCode()})\n" +
                                $"Zijn Gelijk: { equals}");
            Console.WriteLine();
            equals = Boek.Equals(HarryPotterGobletFire1, HarryPotterGobletFire2);
            Console.WriteLine($"Zijn {HarryPotterGobletFire1.ToString()}(Hash = {HarryPotterGobletFire1.GetHashCode()})\n" +
                                $"{HarryPotterGobletFire2.ToString()}(Hash = {HarryPotterGobletFire2.GetHashCode()})\n" +
                                $"Zijn Gelijk: { equals}");

            Console.WriteLine();
            Console.WriteLine();


            // BOEKENREK
            int paginasPerRek = Boekenrek.bladzijdenPerRek;
            Console.WriteLine($"Elk boekenrek kan maximaal {paginasPerRek} bladzijden bewaren.");
            Console.WriteLine();

            Boekenrek ongebruiktRek = new Boekenrek();
            ongebruiktRek.VoegBoekToe(OrwellAnimalFarm);
            ongebruiktRek.PrintBoekenInRek();

            Console.WriteLine();
            Console.WriteLine();

            Boekenrek fantasyRek = new Boekenrek("Fantasy");
            fantasyRek.VoegBoekToe(kafka);
            fantasyRek.VoegBoekToe(HarryPotterGobletFire2);
            fantasyRek.VoegBoekToe(Orwell1984);
            fantasyRek.VoegBoekToe(OrwellAnimalFarm);
            fantasyRek.PrintBoekenInRek();

            Console.WriteLine();
            Console.WriteLine();

            ongebruiktRek.Category = "Sci-Fi";
            ongebruiktRek.VoegBoekToe(OrwellAnimalFarm);
            ongebruiktRek.VoegBoekToe(HarryPotterGobletFire1);
            ongebruiktRek.PrintBoekenInRek();

        }
    }
}
