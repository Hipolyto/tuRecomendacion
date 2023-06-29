using Microsoft.Maui.Networking;
using tuRecomendacion.Model;

namespace tuRecomendacion;

public partial class MainPage : ContentPage
{
	int count = 0;
    IConnectivity connectivity;

    public MainPage()
	{
		InitializeComponent();
    }

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		var QuestionModel = new QuestionModel() { Title = "Hola Mundo" };

        await Shell.Current.GoToAsync(nameof(QuestionsPage), true, new Dictionary<string, object>
    {
        {"QuestionModel", QuestionModel }
    });
    }
}


