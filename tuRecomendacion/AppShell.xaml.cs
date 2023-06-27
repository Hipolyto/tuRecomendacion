using tuRecomendacion.Views;

namespace tuRecomendacion;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        //Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(QuestionsPage), typeof(QuestionsPage));
        Routing.RegisterRoute(nameof(ResultsListPage), typeof(ResultsListPage));
    }
}

