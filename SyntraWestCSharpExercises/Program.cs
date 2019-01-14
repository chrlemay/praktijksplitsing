using System;
using SyntraWestCSharpExercises.Variables;
using SyntraWestCSharpExercises.BuildingBlock2_Operatoren;
using SyntraWestCSharpExercises.BuildingBlock3_Selectie;
using SyntraWestCSharpExercises.BuildingBlock4_Iterations;
using SyntraWestCSharpExercises.BuildingBlock5_Arrays;
using SyntraWestCSharpExercises.BuildingBlock6_IntroOOP.Opdracht06_01Kerstmis;
using System.Collections.Generic;
using SyntraWestCSharpExercises.BuildingBlock6_IntroOOP.Opdracht06_00Facturen;
using SyntraWestCSharpExercises.BuildingBlock7_OOP.Voorbeeld07_00Boeken;
using SyntraWestCSharpExercises.BuildingBlock7_OOP.Opdracht07_01Videotheek;
using SyntraWestCSharpExercises.BuildingBlock8_Methods;
using SyntraWestCSharpExercises.BuildingBlock9_Classes.Opdracht09_01Rekenmachine;
using SyntraWestCSharpExercises.BuildingBlock9_Classes.Opdracht09_02Dagboek;
using SyntraWestCSharpExercises.BuildingBlock9_Classes.Opdracht09_03Vrienden;
using SyntraWestCSharpExercises.BuildingBlock9_Classes.Opdracht09_04Vuilbak;
using SyntraWestCSharpExercises.BuildingBlock9_Classes.Opdracht09_05Pretpark;
using SyntraWestCSharpExercises.BuildingBlock9_Classes.Opdracht09_06RodeKruis;

namespace SyntraWestCSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Als je met een menu wilt werken mag je oefening leeg laten;
            // vul oefening in in de vorm 'buildingBlock.Opdracht'
            // vb 2.6 of 2_6
            string oefening = "9.4";

            #region mainLogic

            try
            {
                RunExercise(oefening);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Er is Exception gesmeten tijdens het runnen van je programma\n" +
                    $"{e.Message}");
            }
            
            Console.WriteLine("\nEINDE MAIN METHOD");
            Console.ReadLine();

            #endregion
        }

        #region intialize Exercises

        #region Building Block I - Variables

        static ExerciseBase opdracht1_1 = new Opdracht01_01IngaveEnWeergevenNaamEnAdres();
        static ExerciseBase opdracht1_2 = new Opdracht01_02BerekenenOmtrekEnOppervlakteRechthoek();
        static ExerciseBase opdracht1_3 = new Opdracht01_03AankopenGroentenFruit();
        static ExerciseBase opdracht1_4 = new Opdracht01_04KostprijsVervenVanDeuren();

        #endregion

        #region Building Block II - Operators

        static ExerciseBase opdracht2_1 = new Opdracht02_01AbsoluteWaarde();
        static ExerciseBase opdracht2_2 = new Opdracht02_02TweeGelijkeGetallen();
        static ExerciseBase opdracht2_3 = new Opdracht02_03ConvertCelciusToFarenheit();
        static ExerciseBase opdracht2_4 = new Opdracht02_04ConvertFarenheitToCelcius();
        static ExerciseBase opdracht2_5 = new Opdracht02_05SecondenOmzetenNaarUrenMinutenSeconden();
        static ExerciseBase opdracht2_6 = new Opdracht02_06BepaalPlaatswaarden();
        static ExerciseBase opdracht2_7 = new Opdracht02_07DagenTotNieuwJaar();
        static ExerciseBase opdracht2_8 = new Opdracht02_08InchNaarCm();
        static ExerciseBase opdracht2_9 = new Opdracht02_09CmNaarInch();
        static ExerciseBase opdracht2_10 = new Opdracht02_10OmwisselenTweeVariabelen();
        static ExerciseBase opdracht2_11 = new Opdracht02_11BerekenPrijsInclusiefBtw();
        static ExerciseBase opdracht2_12 = new Opdracht02_12BerekenPrijsKortingEnBtw();
        static ExerciseBase opdracht2_13 = new Opdracht02_13BtwValidatie();
        static ExerciseBase opdracht2_14 = new Opdracht02_14Scores();
        static ExerciseBase opdracht2_15 = new Opdracht02_15Snoepautomaat();
        static ExerciseBase opdracht2_16 = new Opdracht02_16EvenOfOneven();
        static ExerciseBase opdracht2_17 = new Opdracht02_17Kwadraat();
        static ExerciseBase opdracht2_18 = new Opdracht02_18OverurenBrutoloon();
        static ExerciseBase opdracht2_19 = new Opdracht02_19GewichtVoorConstructie();
        static ExerciseBase opdracht2_20 = new Opdracht02_20Remafstand();

        #endregion

        #region Building Block III - Selectie

        static ExerciseBase opdracht3_1 = new Opdracht03_01AbsoluteWaarde();
        static ExerciseBase opdracht3_2 = new Opdracht03_02ZelfdeGetal();
        static ExerciseBase opdracht3_3 = new Opdracht03_03GrootsteGetal();
        static ExerciseBase opdracht3_4 = new Opdracht03_04EvenOfOneven();
        static ExerciseBase opdracht3_5 = new Opdracht03_05Cinema();
        static ExerciseBase opdracht3_6 = new Opdracht03_06Vrachtwagen();
        static ExerciseBase opdracht3_7 = new Opdracht03_07Portkosten();
        static ExerciseBase opdracht3_8 = new Opdracht03_08MultipleChoice();
        static ExerciseBase opdracht3_9 = new Opdracht03_09DagVanDeWeek();
        static ExerciseBase opdracht3_10 = new Opdracht03_10DagenPerMaand();
        static ExerciseBase opdracht3_11 = new Opdracht03_11Leeftijd();
        static ExerciseBase opdracht3_12 = new Opdracht03_12RomeinsGetal();
        static ExerciseBase opdracht3_13 = new Opdracht03_13CirkelRechthoekVierkant();
        static ExerciseBase opdracht3_14 = new Opdracht03_14DecimaalNaarBinair();
        static ExerciseBase opdracht3_15 = new Opdracht03_15DecimaalNaarHexadecimaal();
        static ExerciseBase opdracht3_16 = new Opdracht03_16OmzettenTalstelsels();
        static ExerciseBase opdracht3_17 = new Opdracht03_17Temperatuur();
        static ExerciseBase opdracht3_18 = new Opdracht03_18Duurtijd();
        static ExerciseBase opdracht3_19 = new Opdracht03_19Factuur();
        static ExerciseBase opdracht3_20 = new Opdracht03_20Deling();
        static ExerciseBase opdracht3_21 = new Opdracht03_21EenvoudigeSortering();
        static ExerciseBase opdracht3_22 = new Opdracht03_22Examen();
        static ExerciseBase opdracht3_23 = new Opdracht03_23Kindergeld();

        #endregion

        #region Building Block IV - Iteratie

        static ExerciseBase opdracht4_1 = new Opdracht04_01Teller();
        static ExerciseBase opdracht4_2 = new Opdracht04_02TellerEnSom();
        static ExerciseBase opdracht4_3 = new Opdracht04_03GrootsteGetal();
        static ExerciseBase opdracht4_4 = new Opdracht04_04AantalPositiefNegatiefEnNul();
        static ExerciseBase opdracht4_5 = new Opdracht04_05Kwadraat();
        static ExerciseBase opdracht4_6 = new Opdracht04_06SomVanOneindigeGetallen();
        static ExerciseBase opdracht4_7 = new Opdracht04_07Delen();
        static ExerciseBase opdracht4_8 = new Opdracht04_08Faculteit();
        static ExerciseBase opdracht4_9 = new Opdracht04_09HalveKerstboom();
        static ExerciseBase opdracht4_10 = new Opdracht04_10Gemiddelde();
        static ExerciseBase opdracht4_11 = new Opdracht04_11OmgekeerdGetal();
        static ExerciseBase opdracht4_12 = new Opdracht04_12BerekeningIntrest();
        static ExerciseBase opdracht4_13 = new Opdracht04_13BerekenenEvenGetallen();
        static ExerciseBase opdracht4_14 = new Opdracht04_14OmzettenCijferResultatenNaarCodes();
        static ExerciseBase opdracht4_15 = new Opdracht04_15HogerLager();
        static ExerciseBase opdracht4_16 = new Opdracht04_16HogerLagerUitbreiding();
        static ExerciseBase opdracht4_17 = new Opdracht04_17Dobbelsteen();
        static ExerciseBase opdracht4_18 = new Opdracht04_18Uurwerk();
        static ExerciseBase opdracht4_19 = new Opdracht04_19Shopping();
        static ExerciseBase opdracht4_20 = new Opdracht04_20Priemgetallen();
        static ExerciseBase opdracht4_21 = new Opdracht04_21RijVanFibonacci();
        static ExerciseBase opdracht4_22 = new Opdracht04_22Ratten();
        static ExerciseBase opdracht4_23 = new Opdracht04_23TafelVanVermenigvuldigen();
        static ExerciseBase opdracht4_24 = new Opdracht04_24Vermenigvuldingsvierkant();
        static ExerciseBase opdracht4_25 = new Opdracht04_25Priemgetal();
        static ExerciseBase opdracht4_26 = new Opdracht04_26Dobbelstenen();
        static ExerciseBase opdracht4_27 = new Opdracht04_27Temperatuur();
        static ExerciseBase opdracht4_28 = new Opdracht04_28Examens();
        static ExerciseBase opdracht4_29 = new Opdracht04_29Lidgeld();

        #endregion

        #region Building Block V - Array

        static ExerciseBase opdracht5_1 = new Opdracht05_01StopWaardenInArray();
        static ExerciseBase opdracht5_2 = new Opdracht05_02Eerste10EvenGetallen();
        static ExerciseBase opdracht5_3 = new Opdracht05_03DrukWaardenOmgekeerd();
        static ExerciseBase opdracht5_4 = new Opdracht05_04NegativeWaarden();
        static ExerciseBase opdracht5_5 = new Opdracht05_05SomVanEntriesUitArray();
        static ExerciseBase opdracht5_6 = new Opdracht05_06GeefLengteVanArray();
        static ExerciseBase opdracht5_7 = new Opdracht05_07GeefLengteEnWaarden();
        static ExerciseBase opdracht5_8 = new Opdracht05_08GeefLengteArrayGeefWaardeEnSom();
        static ExerciseBase opdracht5_9 = new Opdracht05_09GrootsteKleinsteGemiddelde();
        static ExerciseBase opdracht5_10 = new Opdracht05_10EvenOneven();
        static ExerciseBase opdracht5_11 = new Opdracht05_11Zoeken();
        static ExerciseBase opdracht5_12 = new Opdracht05_12SomMetOpvolger();
        static ExerciseBase opdracht5_13 = new Opdracht05_13WaardenGescheidenDoorKomma();
        static ExerciseBase opdracht5_14 = new Opdracht05_14ZoekWaardeInArray();
        static ExerciseBase opdracht5_15 = new Opdracht05_15Boerderijdieren();
        static ExerciseBase opdracht5_16 = new Opdracht05_16PuntenVoorEenVak();
        static ExerciseBase opdracht5_17 = new Opdracht05_17Twister();
        static ExerciseBase opdracht5_18 = new Opdracht05_18InvoegenInArray();
        static ExerciseBase opdracht5_19 = new Opdracht05_19VerwijderenUitArray();
        static ExerciseBase opdracht5_20 = new Opdracht05_20HoeveelKeerKomtGetalVoor();

        #endregion

        #region Building BLock VI - Intro To OOP (Encapsulation)

        static ExerciseBase opdracht6_0 = new Opdracht06_00Facturen();
        static ExerciseBase opdracht6_1 = new Opdracht06_01Kerstmis();

        #endregion
        
        #region Building Block VII - OOP

        static ExerciseBase opdracht7_0 = new Opdracht07_00Boeken();
        static ExerciseBase opdracht7_1 = new Opdracht07_01Videotheek();

        #endregion

        #region Building Block VIII - Methods

        static ExerciseBase opdracht8_1 = new Opdracht08_01VolledigeNaam();
        static ExerciseBase opdracht8_2 = new Opdracht08_02VolledigeNaamMetReturnString();
        static ExerciseBase opdracht8_3 = new Opdracht08_03VolledigeNaamVraagNaamEnVoornaamInMethod();
        static ExerciseBase opdracht8_4 = new Opdracht08_04VolledigeNaamgVraagNaamEnVoornaamInMethodEnReturn();
        static ExerciseBase opdracht8_5 = new Opdracht08_05ValideerOpEenLegeString();
        static ExerciseBase opdracht8_6 = new Opdracht08_06ValideerNaamEnVoornaam();
        static ExerciseBase opdracht8_7 = new Opdracht08_07ValideerNaamEnVoornaamEnPrint();
        static ExerciseBase opdracht8_8 = new Opdracht08_08PrintVolledigeNaamEnVallideerMethod();
        static ExerciseBase opdracht8_9 = new Opdracht08_09GetVolledigeNaamEnVallideer();
        static ExerciseBase opdracht8_10 = new Opdracht08_10PrintLijn();
        static ExerciseBase opdracht8_11 = new Opdracht08_11PrintLijnMetZelfGekozenKarakter();
        static ExerciseBase opdracht8_12 = new Opdracht08_12PrintTitelEnLijn();
        static ExerciseBase opdracht8_13 = new Opdracht08_13TryParseInteger();
        static ExerciseBase opdracht8_14 = new Opdracht08_14TryParseIntegerCustomErrorMessage();
        static ExerciseBase opdracht8_15 = new Opdracht08_15SomPuntenEnCheckDePuntenMetDeGetGetalMethod();
        static ExerciseBase opdracht8_16 = new Opdracht08_16PrintArray();
        static ExerciseBase opdracht8_17 = new Opdracht08_17ZoekWaardeInArray();
        static ExerciseBase opdracht8_18 = new Opdracht08_18MaakArray();
        static ExerciseBase opdracht8_19 = new Opdracht08_19GeefWaardeAanEntryArray();
        static ExerciseBase opdracht8_20 = new Opdracht08_20VulElkeEntryVanArray();

        #endregion

        #region Building Block IX - classes


        static ExerciseBase opdracht9_1 = new Opdracht09_01Vrienden();
        static ExerciseBase opdracht9_2 = new Opdracht09_02Dagboek();
        static ExerciseBase opdracht9_3 = new Opdracht09_03Vuilbak();
        static ExerciseBase opdracht9_4 = new Opdracht09_04Rekenmachine();
        static ExerciseBase opdracht9_5 = new Opdracht09_05Pretpark();
        static ExerciseBase opdracht9_6 = new Opdracht09_06RodeKruis();

        #endregion

        static readonly Dictionary<string, Dictionary<string, Action>> exercises = new Dictionary<string, Dictionary<string, Action>>
        {
            {"1", new Dictionary<string, Action>
                {
                    {"1", () => opdracht1_1.RunExercise()},
                    {"2", () => opdracht1_2.RunExercise()},
                    {"3", () => opdracht1_3.RunExercise()},
                    {"4", () => opdracht1_4.RunExercise()},
                }
            },
            {"2", new Dictionary<string, Action>
                {
                    {"1", () => opdracht2_1.RunExercise()},
                    {"2", () => opdracht2_2.RunExercise()},
                    {"3", () => opdracht2_3.RunExercise()},
                    {"4", () => opdracht2_4.RunExercise()},
                    {"5", () => opdracht2_5.RunExercise()},
                    {"6", () => opdracht2_6.RunExercise()},
                    {"7", () => opdracht2_7.RunExercise()},
                    {"8", () => opdracht2_8.RunExercise()},
                    {"9", () => opdracht2_9.RunExercise()},
                    {"10", () => opdracht2_10.RunExercise()},
                    {"11", () => opdracht2_11.RunExercise()},
                    {"12", () => opdracht2_12.RunExercise()},
                    {"13", () => opdracht2_13.RunExercise()},
                    {"14", () => opdracht2_14.RunExercise()},
                    {"15", () => opdracht2_15.RunExercise()},
                    {"16", () => opdracht2_16.RunExercise()},
                    {"17", () => opdracht2_17.RunExercise()},
                    {"18", () => opdracht2_18.RunExercise()},
                    {"19", () => opdracht2_19.RunExercise()},
                    {"20", () => opdracht2_20.RunExercise()}
                }
            },
            {"3", new Dictionary<string, Action>
                {
                    {"1", () => opdracht3_1.RunExercise()},
                    {"2", () => opdracht3_2.RunExercise()},
                    {"3", () => opdracht3_3.RunExercise()},
                    {"4", () => opdracht3_4.RunExercise()},
                    {"5", () => opdracht3_5.RunExercise()},
                    {"6", () => opdracht3_6.RunExercise()},
                    {"7", () => opdracht3_7.RunExercise()},
                    {"8", () => opdracht3_8.RunExercise()},
                    {"9", () => opdracht3_9.RunExercise()},
                    {"10", () => opdracht3_10.RunExercise()},
                    {"11", () => opdracht3_11.RunExercise()},
                    {"12", () => opdracht3_12.RunExercise()},
                    {"13", () => opdracht3_13.RunExercise()},
                    {"14", () => opdracht3_14.RunExercise()},
                    {"15", () => opdracht3_15.RunExercise()},
                    {"16", () => opdracht3_16.RunExercise()},
                    {"17", () => opdracht3_17.RunExercise()},
                    {"18", () => opdracht3_18.RunExercise()},
                    {"19", () => opdracht3_19.RunExercise()},
                    {"20", () => opdracht3_20.RunExercise()},
                    {"21", () => opdracht3_21.RunExercise()},
                    {"22", () => opdracht3_22.RunExercise()},
                    {"23", () => opdracht3_23.RunExercise()}
                }
            } ,
            {"4", new Dictionary<string, Action>
                {
                    {"1", () => opdracht4_1.RunExercise()},
                    {"2", () => opdracht4_2.RunExercise()},
                    {"3", () => opdracht4_3.RunExercise()},
                    {"4", () => opdracht4_4.RunExercise()},
                    {"5", () => opdracht4_5.RunExercise()},
                    {"6", () => opdracht4_6.RunExercise()},
                    {"7", () => opdracht4_7.RunExercise()},
                    {"8", () => opdracht4_8.RunExercise()},
                    {"9", () => opdracht4_9.RunExercise()},
                    {"10", () => opdracht4_10.RunExercise()},
                    {"11", () => opdracht4_11.RunExercise()},
                    {"12", () => opdracht4_12.RunExercise()},
                    {"13", () => opdracht4_13.RunExercise()},
                    {"14", () => opdracht4_14.RunExercise()},
                    {"15", () => opdracht4_15.RunExercise()},
                    {"16", () => opdracht4_16.RunExercise()},
                    {"17", () => opdracht4_17.RunExercise()},
                    {"18", () => opdracht4_18.RunExercise()},
                    {"19", () => opdracht4_19.RunExercise()},
                    {"20", () => opdracht4_20.RunExercise()},
                    {"21", () => opdracht4_21.RunExercise()},
                    {"22", () => opdracht4_22.RunExercise()},
                    {"23", () => opdracht4_23.RunExercise()},
                    {"24", () => opdracht4_24.RunExercise()},
                    {"25", () => opdracht4_25.RunExercise()},
                    {"26", () => opdracht4_26.RunExercise()},
                    {"27", () => opdracht4_27.RunExercise()},
                    {"28", () => opdracht4_28.RunExercise()},
                    {"29", () => opdracht4_29.RunExercise()}
                }
            },
            {"5", new Dictionary<string, Action>
                {
                    { "1", () => opdracht5_1.RunExercise() },
                    { "2", () => opdracht5_2.RunExercise() },
                    { "3", () => opdracht5_3.RunExercise() },
                    { "4", () => opdracht5_4.RunExercise() },
                    { "5", () => opdracht5_5.RunExercise() },
                    { "6", () => opdracht5_6.RunExercise() },
                    { "7", () => opdracht5_7.RunExercise() },
                    { "8", () => opdracht5_8.RunExercise() },
                    { "9", () => opdracht5_9.RunExercise() },
                    { "10", () => opdracht5_10.RunExercise() },
                    { "11", () => opdracht5_11.RunExercise() },
                    { "12", () => opdracht5_12.RunExercise() },
                    { "13", () => opdracht5_13.RunExercise() },
                    { "14", () => opdracht5_14.RunExercise() },
                    { "15", () => opdracht5_15.RunExercise() },
                    { "16", () => opdracht5_16.RunExercise() },
                    { "17", () => opdracht5_17.RunExercise() },
                    { "18", () => opdracht5_18.RunExercise() },
                    { "19", () => opdracht5_19.RunExercise() },
                    { "20", () => opdracht5_20.RunExercise() }
                }
            },
            {"6", new Dictionary<string, Action>
                {
                    { "0", () => opdracht6_0.RunExercise() },
                    { "1", () => opdracht6_1.RunExercise() }
                }
            },
            {"7", new Dictionary<string, Action>
                {
                    { "0", () => opdracht7_0.RunExercise() },
                    { "1", () => opdracht7_1.RunExercise() }
                }
            },
            {"8", new Dictionary<string, Action>
                {
                    { "1", () => opdracht8_1.RunExercise() },
                    { "2", () => opdracht8_2.RunExercise() },
                    { "3", () => opdracht8_3.RunExercise() },
                    { "4", () => opdracht8_4.RunExercise() },
                    { "5", () => opdracht8_5.RunExercise() },
                    { "6", () => opdracht8_6.RunExercise() },
                    { "7", () => opdracht8_7.RunExercise() },
                    { "8", () => opdracht8_8.RunExercise() },
                    { "9", () => opdracht8_9.RunExercise() },
                    { "10", () => opdracht8_10.RunExercise() },
                    { "11", () => opdracht8_11.RunExercise() },
                    { "12", () => opdracht8_12.RunExercise() },
                    { "13", () => opdracht8_13.RunExercise() },
                    { "14", () => opdracht8_14.RunExercise() },
                    { "15", () => opdracht8_15.RunExercise() },
                    { "16", () => opdracht8_16.RunExercise() },
                    { "17", () => opdracht8_17.RunExercise() },
                    { "18", () => opdracht8_18.RunExercise() },
                    { "19", () => opdracht8_19.RunExercise() },
                    { "20", () => opdracht8_20.RunExercise() }
                }
            },
            {"9", new Dictionary<string, Action>
                {
                    { "1", () => opdracht9_1.RunExercise() },
                    { "2", () => opdracht9_2.RunExercise() },
                    { "3", () => opdracht9_3.RunExercise() },
                    { "4", () => opdracht9_4.RunExercise() },
                    { "5", () => opdracht9_5.RunExercise() },
                    { "6", () => opdracht9_6.RunExercise() }
                }
            }
        };

        #endregion

        static void RunExercise(string oefening)
        {
            var oefeningSplit = oefening.Split(new char[] { '.', '_' });

            string buildingBlock, opdrachtNummer;

            try
            {
                buildingBlock = oefeningSplit[0];
                opdrachtNummer = oefeningSplit[1];
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("Oefening is niet in het juiste formaat gegeven.");
            }

            var opdrachten = exercises.GetValueOrDefault(buildingBlock);

            if (opdrachten == null)
            {
                throw new InvalidOperationException($"Building block {buildingBlock} bestaat niet.");
            }

            var opdracht = opdrachten.GetValueOrDefault(opdrachtNummer);

            if(opdracht == null)
            {
                throw new InvalidOperationException($"Opdracht {opdrachtNummer} bestaat niet.");
            }

            Console.WriteLine($"Exercise {oefening}");
            Console.WriteLine("--------------------\n");
            opdracht();
        }
    }
}