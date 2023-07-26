using System.Collections.ObjectModel;
using tuRecomendacion.Model;
using tuRecomendacion.ViewModels;

namespace tuRecomendacion.Views;

public partial class ResultsListPage : ContentPage
{
    public ResultsListViewModel ViewModel;

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