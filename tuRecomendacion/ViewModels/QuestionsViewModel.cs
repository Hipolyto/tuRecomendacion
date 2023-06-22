using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using Microsoft.Maui.Networking;
using tuRecomendacion.Interfaces;
using tuRecomendacion.Model;

namespace tuRecomendacion.ViewModels
{
    [QueryProperty(nameof(QuestionModel), "QuestionModel")]
    public class QuestionsViewModel : BaseViewModel
    {
        private Question _currentQuestion;
        private int _currentQuestionIndex;
        private List<Question> _questions;

        public QuestionsViewModel()
        {
            _currentQuestionIndex = 0;

            // Define las preguntas y sus opciones aquí.
            _questions = new List<Question>
        {
            new Question("¿Cuál es tu edad?", new List<QuestionOption>
            {
                new QuestionOption("Menos de 18 años", 1),
                new QuestionOption("18-25 años", 2),
                new QuestionOption("26-35 años", 3),
                new QuestionOption("36-45 años", 4),
                new QuestionOption("Más de 45 años", 5)
            }),
            new Question("¿Estás con tu pareja o amigos?", new List<QuestionOption>
            {
                new QuestionOption("Pareja", 1),
                new QuestionOption("Amigos", 2),
                new QuestionOption("Solo", 3),
            }),
            new Question("¿Es de día, noche o tarde?", new List<QuestionOption>
            {
                new QuestionOption("Día", 1),
                new QuestionOption("Tarde", 2),
                new QuestionOption("Noche", 3),
            }),
            new Question("¿Formal o casual?", new List<QuestionOption>
            {
                new QuestionOption("Formal", 1),
                new QuestionOption("Casual", 2),
            })
        };

            CurrentQuestion = _questions[_currentQuestionIndex];
        }

        public Question CurrentQuestion
        {
            get => _currentQuestion;
            set
            {
                _currentQuestion = value;
                OnPropertyChanged(nameof(CurrentQuestion));
            }
        }

        public bool CanMoveNext => _currentQuestionIndex < _questions.Count - 1;
        public bool CanMovePrev => _currentQuestionIndex > 0;

        public List<QuestionOption> Answers { get; } = new List<QuestionOption>();

        public Command MoveNextCommand => new Command(MoveNext, () => CanMoveNext);
        public Command MovePrevCommand => new Command(MovePrev, () => CanMovePrev);

        public void SelectOption(QuestionOption option)
        {
            if (option != null)
            {
                Answers.Add(option);
                MoveNext();
            }
        }

        private async void MoveNext()
        {
            if (CanMoveNext)
            {
                _currentQuestionIndex++;
                CurrentQuestion = _questions[_currentQuestionIndex];
                ((Command)MoveNextCommand).ChangeCanExecute();
                ((Command)MovePrevCommand).ChangeCanExecute();
            }
            else
            {
                await Shell.Current.GoToAsync(nameof(QuestionsPage), true, new Dictionary<string, object>
                {
                    {"questions", _questions }
                });
            }
        }

        private void MovePrev()
        {
            if (CanMovePrev)
            {
                _currentQuestionIndex--;
                CurrentQuestion = _questions[_currentQuestionIndex];
                ((Command)MoveNextCommand).ChangeCanExecute();
                ((Command)MovePrevCommand).ChangeCanExecute();
            }
        }
    }

}

