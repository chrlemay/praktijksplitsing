using Quizes.BuildingBlockV_Arrays;
using System;
using System.Collections.Generic;

namespace Quizes.ExerciseGenerators
{
    public class DeclareArrayExerciseGenerator : ExerciseGenerator
    {
        private readonly RandomNumberGenerator _numberGenerator;
        private string DataType { get; set; }
        private string ArrayName { get; set; }

        public DeclareArrayExerciseGenerator(RandomNumberGenerator numberGenerator)
        {
            _numberGenerator = numberGenerator ?? throw new ArgumentNullException(nameof(numberGenerator));
        }

        public override ExerciseBase GenerateNewExercise()
        {
            DataType = DataTypes.Types[_numberGenerator.Next(DataTypes.Types.Count - 1)];
            var arrayNames = ArrayNames.ArrayNamesPerDataType[DataType];
            ArrayName = arrayNames[arrayNames.Count - 1].Split("|")[0];

            var exercise = new DeclareArraysExercise();

            var numberOfAnswers = 4;

            var randomList = _numberGenerator.RandomNumberList(5,numberOfAnswers, 0);
            var list = new List<int[]>
            {
                new int[]{1,2,3},
                new int[]{1,3,2},
                new int[]{2,1,3},
                new int[]{2,3,1},
                new int[]{3,1,2},
                new int[]{3,2,1}
            };

            exercise.CorrectAnswer = randomList.IndexOf(0).ToString();

            for (int i = 0; i < numberOfAnswers; i++)
            {
                var pattern = list[randomList[i]];
                exercise.Answers.Add($"{PatternPart(pattern[0])} {PatternPart(pattern[1])} {PatternPart(pattern[2])};");
            }

            return exercise;
        }

        private string PatternPart(int part)
        {
            if(part <= 0 || part > 3)
            {
                throw new ArgumentException("Part should be between 1 and 3");
            }

            string output;

            switch (part)
            {
                case 1:
                    output = DataType;
                    break;

                case 2:
                    output = "[]";
                    break;

                case 3:
                    output = ArrayName;
                    break;

                default:
                    output = string.Empty;
                    break;
            }

            return output;
        }
    }
}
