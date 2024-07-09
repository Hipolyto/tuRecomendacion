using System.Collections.ObjectModel;
using tuRecomendacion.Model;
using tuRecomendacion.ViewModels;

namespace tuRecomendacion.Views;

[QueryProperty(nameof(QuestionsList), "QuestionsList")]
public partial class ResultsListPage : ContentPage
{
    public ResultsListViewModel ViewModel;

    object name;
    public object QuestionsList
    {
        get => name;
        set => name = value;
    }

    public ResultsListPage(ResultsListViewModel viewModel)
	{
		InitializeComponent();
        ViewModel = viewModel;
        BindingContext = viewModel;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ViewModel.OnAppearing();
    }
}