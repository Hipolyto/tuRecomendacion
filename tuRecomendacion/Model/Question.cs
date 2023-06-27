using System.ComponentModel;

namespace tuRecomendacion.Model
{
    public class Question : BaseModel
    {
        public string Id { get; set; }               // The question's unique identifier
        public string Text { get; set; }             // The question text
        public List<QuestionOption> Choices { get; set; }    // The possible choices for this question
                                                             // ... add more properties as needed ...

        QuestionOption _answer;
        public QuestionOption Answer
        {
            get => _answer;
            set => SetProperty(ref _answer, value);
        }

        public Question(string text, List<QuestionOption> options)
        {
            Text = text;
            Choices = options;
        }
        public Question()
        {
        }
    }

    public class QuestionOption : BaseModel
    {
        public string Text { get; set; }
        public int Value { get; set; }
        int _answersCount = 0;
        public int AnswerCount
        {
            get => _answersCount;
            set => SetProperty(ref _answersCount, value);
        }

        bool _isSelected = false;
        public bool IsSelected
        {
            get => _isSelected;
            set => SetProperty(ref _isSelected, value);
        }

        public QuestionOption(string text, int value = 0)
        {
            Text = text;
            Value = value;
        }
    }

}

