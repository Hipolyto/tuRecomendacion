using System.Windows.Input;
using tuRecomendacion.Interfaces;
using tuRecomendacion.Model;
namespace tuRecomendacion.ViewModels;

public class LoginViewModel : BaseViewModel
{
    private readonly IAuthService _authService;
    private readonly IAppleAuthService _authAppleService;

    public ICommand FacebookLoginCommand { get; }
    public ICommand AppleLoginCommand { get; }

    public LoginViewModel(IAuthService authService, IAppleAuthService authAppleService)
    {
        _authService = authService;
        _authAppleService = authAppleService;

        FacebookLoginCommand = new Command(async () => await OnFacebookLoginClicked());
        AppleLoginCommand = new Command(async () => await OnAppleLoginClicked());
    }

    private async Task OnFacebookLoginClicked()
    {
        // Call the authService to sign in
        var user = await _authService.SignInAsync();

        // Navigate to the next page if successful...
        if (user != null)
        {
            var QuestionModel = new QuestionModel() { Title = "Hola Mundo Fb" };
            await Shell.Current.GoToAsync(nameof(QuestionsPage), true, new Dictionary<string, object>
            {
                {"QuestionModel", QuestionModel }
            });

        }
    }

    private async Task OnAppleLoginClicked()
    {
        // Call the authService to sign in
        var user = await _authAppleService.SignInAsync();

        // Navigate to the next page if successful...
        if (user != null)
        {
            var QuestionModel = new QuestionModel() { Title = "Hola Mundo Apple" };
            await Shell.Current.GoToAsync(nameof(QuestionsPage), true, new Dictionary<string, object>
            {
                {"QuestionModel", QuestionModel }
            });
        }
    }
}

