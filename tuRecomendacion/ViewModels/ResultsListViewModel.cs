using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tuRecomendacion.Model;

namespace tuRecomendacion.ViewModels
{
    public class ResultsListViewModel : BaseViewModel
    {
        public ResultsListViewModel(List<Question> questions)
        {
            Questions = new ObservableCollection<Question>(questions);
        }

        public ObservableCollection<Question> Questions { get; }
    }
}
