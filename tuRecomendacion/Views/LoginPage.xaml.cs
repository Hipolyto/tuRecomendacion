using tuRecomendacion.ViewModels;

namespace tuRecomendacion.Views;

public partial class LoginPage : ContentPage
{

    public LoginPage(LoginViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}

