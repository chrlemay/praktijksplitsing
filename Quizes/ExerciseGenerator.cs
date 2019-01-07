using System;

namespace Quizes
{
    public abstract class ExerciseGenerator : IExerciseGenerator
    {
        public abstract ExerciseBase GenerateNewExercise();
    }
}
