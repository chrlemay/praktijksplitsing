using Quizes.BuildingBlockV_Arrays;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quizes.ExerciseGenerators
{
    public class InitializeArrayExerciseGenerator : ExerciseGenerator
    {
        private readonly RandomNumberGenerator _numberGenerator;
        private string DataType { get; set; }
        private string ArrayName { get; set; }
        private string ArrayFilled { get; set; }

        public InitializeArrayExerciseGenerator(RandomNumberGenerator randomGenerator)
        {
            _numberGenerator = randomGenerator ?? throw new ArgumentNullException(nameof(randomGenerator));
        }

        public override ExerciseBase GenerateNewExercise()
        {
            DataType = DataTypes.Types[_numberGenerator.Next(DataTypes.Types.Count - 1)];
            var arrayNames = ArrayNames.ArrayNamesPerDataType[DataType];
            var arrayParts = arrayNames[arrayNames.Count - 1].Split("|");
            ArrayName = arrayParts[0];
            ArrayFilled = arrayParts[1];

            var exercise = new InitializeArraysExercise();

            var numberOfAnswers = 4;

            var list = new List<int[]>
            {
                new int[]{1,2,4},
                new int[]{1,2,3,5},
                new int[]{5},
                new int[]{1,3,5},

                new int[]{2,3},
                new int[]{2,4},
                new int[]{1,5},
                new int[]{1,2,5},
                new int[]{3,5},
                new int[]{1,2,3},
                new int[]{5,3},
                new int[]{1,3},
                new int[]{1,3,2},
            };
            var randomList = _numberGenerator
                .RandomNumberList(list.Count - 1, numberOfAnswers, new int[] { 0, 1, 2, 3 });

            for (int i = 0; i < numberOfAnswers; i++)
            {
                int index = randomList[i];
                if(index < 4)
                {
                    exercise.CorrectAnswer = i.ToString();
                }

                var pattern = list[index];
                var stringbuilder = new StringBuilder();
                stringbuilder.Append($"{DataType}[] {ArrayName} = ");

                foreach(var part in pattern)
                {
                    stringbuilder.Append($"{PatternPart(part)} ");
                }

                exercise.Answers.Add(stringbuilder.ToString());
            }

            return exercise;
        }

        private string PatternPart(int part)
        {
            if (part <= 0 || part > 5)
            {
                throw new ArgumentException("Part should be between 1 and 5");
            }

            string output;

            switch (part)
            {
                case 1:
                    output = "new";
                    break;

                case 2:
                    output = DataType;
                    break;

                case 3:
                    output = "[]";
                    break;

                case 4:
                    output = $"[{_numberGenerator.Next(10)}]";
                    break;

                case 5:
                    output = ArrayFilled;
                    break;

                default:
                    output = string.Empty;
                    break;
            }

            return output;
        }
    }
}
