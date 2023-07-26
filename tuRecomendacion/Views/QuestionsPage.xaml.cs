
using tuRecomendacion.ViewModels;

namespace tuRecomendacion;

[QueryProperty(nameof(Name), "name")]
public partial class QuestionsPage : ContentPage
{
    string name;
    public string Name
    {
        get => name;
        set => name = value;
    }

    public QuestionsViewModel ViewModel;

    public QuestionsPage(QuestionsViewModel viewModel)
	{
		InitializeComponent();
        ViewModel = viewModel;
        BindingContext = ViewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ViewModel.OnAppearing();
    }
}
