using System.Collections.ObjectModel;
using tuRecomendacion.Model;
using tuRecomendacion.ViewModels;

namespace tuRecomendacion.Views;

public partial class ResultsListPage : ContentPage
{
	public ResultsListPage(List<Question> questions)
	{
		InitializeComponent();
		BindingContext = new ResultsListViewModel(questions);
	}
}