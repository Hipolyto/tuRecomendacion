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
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		//SemanticScreenReader.Announce(CounterBtn.Text);

		//await Shell.Current.GoToAsync("QuestionsPage?name=james");

		var QuestionModel = new QuestionModel() { Title = "Hola Mundo" };


        if (connectivity?.NetworkAccess != NetworkAccess.Internet)
        {
            //await Shell.Current.DisplayAlert("No connectivity!",
              //  $"Please check internet and try again.", "OK");
            //return;
        }

        await Shell.Current.GoToAsync(nameof(QuestionsPage), true, new Dictionary<string, object>
    {
        {"QuestionModel", QuestionModel }
    });
    }
}


