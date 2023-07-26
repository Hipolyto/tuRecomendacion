using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using Microsoft.Maui.Networking;
using tuRecomendacion.Interfaces;
using tuRecomendacion.Model;
using tuRecomendacion.Views;

namespace tuRecomendacion.ViewModels
{
    [QueryProperty(nameof(QuestionModel), "QuestionModel")]
    public class QuestionsViewModel : BaseViewModel
    {
        private Question _currentQuestion;
        private int _currentQuestionIndex = 0;
        private QuestionOption _selectedOption;

        public QuestionModel QuestionModel { get; set; }

        public QuestionsViewModel()
        {
            MovePrevCommand = new Command(MovePrev, CanMovePrevAction);
            MoveNextCommand = new Command(MoveNext, CanMoveNextAction);

            // Define las preguntas y sus opciones aquí.
            Questions = new ObservableCollection<Question>
{
    new Question("What is your age?", new List<QuestionOption>
    {
        new QuestionOption("Under 18 years old", 1),
        new QuestionOption("18-25 years old", 2),
        new QuestionOption("26-35 years old", 3),
        new QuestionOption("36-45 years old", 4),
        new QuestionOption("Over 45 years old", 5)
    }),
    new Question("Are you with your partner or friends?", new List<QuestionOption>
    {
        new QuestionOption("Partner", 1),
        new QuestionOption("Friends", 2),
        new QuestionOption("Alone", 3),
    }),
    new Question("Is it day, evening, or night?", new List<QuestionOption>
    {
        new QuestionOption("Day", 1),
        new QuestionOption("Evening", 2),
        new QuestionOption("Night", 3),
    }),
    new Question("Formal or casual?", new List<QuestionOption>
    {
        new QuestionOption("Formal", 1),
        new QuestionOption("Casual", 2),
    })
};

        }

        public int CurrentQuestionIndex
        {
            get => _currentQuestionIndex;
            set => SetProperty(ref _currentQuestionIndex, value);
        }
        public QuestionOption SelectedOption
        {
            get => _selectedOption;
            set
            {
                if (SetProperty(ref _selectedOption, value))
                    SelectOption(SelectedOption);
            }
        }
        public ObservableCollection<Question> Questions { get; }
        public bool CanMoveNext => _currentQuestionIndex < Questions.Count - 1;
        public bool CanMovePrev => _currentQuestionIndex > 0;

        public ObservableCollection<QuestionOption> Answers { get; } = new ObservableCollection<QuestionOption>();
        public Command MoveNextCommand { get; }
        public Command MovePrevCommand { get; }

        private bool CanMoveNextAction()
        {
            return CanMoveNext;
        }
        private bool CanMovePrevAction()
        {
            return CanMovePrev;
        }

        public Command OnSelectCommand => new Command<QuestionOption>(q => SelectOption(q));

        public async void SelectOption(QuestionOption option)
        {
            if (option != null)
            {
                Questions[CurrentQuestionIndex].Choices.ForEach(i => i.IsSelected = false);
                option.IsSelected = true;
                await Task.Delay(TimeSpan.FromSeconds(0.5));
                MoveNext();
            }
        }
        private async void MoveNext()
        {
            if (CanMoveNext)
            {
                CurrentQuestionIndex++;
                MoveNextCommand.ChangeCanExecute();
                MovePrevCommand.ChangeCanExecute();
            }
            else
            {
                Questions?.ToList()?.ForEach(i => i.Choices?.ToList()?.ForEach(o => { if (o.IsSelected) o.AnswerCount++; } ));


                await Shell.Current.GoToAsync(nameof(ResultsListPage), true, new Dictionary<string, object>
                {
                    {"QuestionsList", Questions}
                });
            }
        }
        private void MovePrev()
        {
            if (CanMovePrev)
            {
                CurrentQuestionIndex--;
                MovePrevCommand.ChangeCanExecute();
                MoveNextCommand.ChangeCanExecute();
            }
        }


    }

}

