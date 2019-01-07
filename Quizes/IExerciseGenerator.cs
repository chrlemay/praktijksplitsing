using System;

namespace Quizes
{
    public interface IExerciseGenerator
    {
        ExerciseBase GenerateNewExercise();
    }
}
