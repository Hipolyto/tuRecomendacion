namespace tuRecomendacion;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(QuestionsPage), typeof(QuestionsPage));
    }
}

