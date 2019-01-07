using System.Collections.Generic;

namespace Quizes
{
    public abstract class ExerciseBase
    {
        public abstract string Title { get; }
        public abstract string Question { get; }
        public abstract int CorrectAnswersToPass { get; }

        public string CorrectAnswer { get; set; }
        
        public bool CorrectAnswered { get; set; }
        public string Answer { get; set; }

        public List<string> Answers { get; set; } = new List<string>();
    }
}
