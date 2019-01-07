using Quizes.ExerciseGenerators;
using System;
using System.Collections.Generic;

namespace Quizes.DataBase
{
    public static class BuildingBlocksBase
    {
        public static Dictionary<string, List<(string, Func<ExerciseBase>)>> BuildingBlocks => new Dictionary<string, List<(string, Func<ExerciseBase>)>>
        {
            {
                BuildingBlocksR.BuildingBlockV, new List<(string, Func<ExerciseBase>)>
                {
                    (BuildingBlockVQuizesBaseR.DeclareArraysExerciseKey, () => _declareArrayExerciseGenerator.GenerateNewExercise()),
                    (BuildingBlockVQuizesBaseR.IntializeArraysExerciseKey, () => _initializeArrayExerciseGenerator.GenerateNewExercise())
                }
            }
        };

        private static readonly RandomNumberGenerator _numberGenerator = new RandomNumberGenerator();
        private static readonly DeclareArrayExerciseGenerator _declareArrayExerciseGenerator = new DeclareArrayExerciseGenerator(_numberGenerator);
        private static readonly InitializeArrayExerciseGenerator _initializeArrayExerciseGenerator = new InitializeArrayExerciseGenerator(_numberGenerator);
    }
}
