using System;



namespace Quize_app.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string questionTest { get; set; } = string.Empty;

        public string optionA { get; set; } = string.Empty;

        public string optionB { get; set; } = string.Empty;

        public string optionC { get; set; } = string.Empty;

        public string optionD { get; set; } = string.Empty;

        public string correctAnswer { get; set; } = string.Empty;

    }
}
