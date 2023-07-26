using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tuRecomendacion.Model;

namespace tuRecomendacion.ViewModels
{
    [QueryProperty(nameof(QuestionsList), "QuestionsList")]
    public class ResultsListViewModel : BaseViewModel
    {
        public ObservableCollection<Question> QuestionsList { get; set; }

        public ResultsListViewModel()
        {

            QuestionsList = new ObservableCollection<Question>();
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
        }

        public ObservableCollection<Question> Questions { get; }
    }
}
