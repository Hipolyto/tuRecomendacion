namespace tuRecomendacion;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    public override void CloseWindow(Window window)
    {
        base.CloseWindow(window);
    }

    protected override void OnStart()
    {
        base.OnStart();
    }
}

