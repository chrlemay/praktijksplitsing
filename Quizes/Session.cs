using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quizes
{
    public class Session
    {
        private Func<ExerciseBase> GenerateExercise { get; set; }

        public int CorrectStreak { get; set; }

        public bool FirstExercise { get; set; }

        private string Streak => $"{CorrectStreak}/{Exercise.CorrectAnswersToPass}";

        private ExerciseBase Exercise { get; set; }

        public List<ExerciseBase> ExercisesDone { get; set; } = new List<ExerciseBase>();

        public void Start()
        {
            while (CorrectStreak != Exercise.CorrectAnswersToPass)
            {
                Display();
                PromptAnswer();
                CheckAnswer();
                FirstExercise = false;
            }
        }

        private void Display()
        {
            if (FirstExercise)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (CorrectStreak == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine($"{Exercise.Title}\t\t{Streak}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        private void PromptAnswer()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{Exercise.Question}\n");

            var count = Exercise.Answers.Count;
            for (int i = 0; i < count; i++)
            {
                stringBuilder.AppendLine($"{i + 1}) {Exercise.Answers[i]}");
            }

            Console.WriteLine(stringBuilder);

            Exercise.Answer = (ConsoleAid.ReadKeyByte(1, (byte)count) - 1).ToString();
        }

        private void CheckAnswer()
        {
            if (Exercise.Answer.Equals(Exercise.CorrectAnswer))
            {
                Exercise.CorrectAnswered = true;
                CorrectStreak++;
            }
            else
            {
                CorrectStreak = 0;
            }

            ExercisesDone.Add(Exercise);

            if (CorrectStreak == Exercise.CorrectAnswersToPass)
            {
                Console.Clear();
                ShowResultOfSession();
                Console.Clear();
                return;
            }

            ShowResultOfExercise();

            Console.Clear();
            Exercise = GenerateExercise();
        }

        private void ShowResultOfExercise()
        {
            Console.ForegroundColor = Exercise.CorrectAnswered ? ConsoleColor.Green : ConsoleColor.Red;

            Console.WriteLine($"{(Exercise.CorrectAnswered ? "Goed" : "Fout")} geantwoord. " +
                $"{(Exercise.CorrectAnswered ? string.Empty : "Niet erg, leren doe je enkel door fouten te maken.")}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        private void ShowResultOfSession()
        {
            Console.WriteLine("Goed gedaan! hier nogmaals je resultaten.");

            for (int i = 0; i < ExercisesDone.Count; i++)
            {
                ConsoleAid.PrintTitle($"Exercise {i + 1}");
                var exercise = ExercisesDone[i];

                for (int j = 0; j < exercise.Answers.Count; j++)
                {
                    var answer = exercise.Answers[j];

                    if (j.ToString() == exercise.CorrectAnswer)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{answer} {(exercise.Answer == exercise.CorrectAnswer ? "<-- Gekozen" : string.Empty)}");
                    }
                    else if (j.ToString() == exercise.Answer)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{answer} <-- Gekozen");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(answer);
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Druk Enter om verder te gaan ...");
            Console.ReadLine();
        }

        public void Reset(Func<ExerciseBase> generateExercise)
        {
            ExercisesDone.RemoveRange(0, ExercisesDone.Count);
            CorrectStreak = 0;
            FirstExercise = true;
            GenerateExercise = () => generateExercise();
            Exercise = GenerateExercise();
        }
    }
}
