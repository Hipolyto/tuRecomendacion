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

    public QuestionsPage(QuestionsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}
