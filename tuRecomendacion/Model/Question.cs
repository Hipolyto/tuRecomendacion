namespace tuRecomendacion.Model
{
    public class Question
    {
        public string Id { get; set; }               // The question's unique identifier
        public string Text { get; set; }             // The question text
        public List<QuestionOption> Choices { get; set; }    // The possible choices for this question
                                                     // ... add more properties as needed ...

        public QuestionOption Answer { get; set; }

        public Question(string text, List<QuestionOption> options)
        {
            Text = text;
            Choices = options;
        }
        public Question()
        {
        }
    }

    public class QuestionOption
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public QuestionOption(string text, int value = 0)
        {
            Text = text;
            Value = value;
        }
    }

}

