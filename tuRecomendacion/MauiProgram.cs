using System.Reflection.PortableExecutable;
using Microsoft.Extensions.Logging;
using tuRecomendacion.Interfaces;
using tuRecomendacion.Services;
using tuRecomendacion.ViewModels;
using tuRecomendacion.Views;

namespace tuRecomendacion;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

        builder.Services.AddTransient<QuestionsViewModel>();
        builder.Services.AddTransient<LoginViewModel>();
        builder.Services.AddTransient<QuestionsPage>();
        builder.Services.AddTransient<LoginPage>();

        builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
        builder.Services.AddSingleton<IGeolocation>(Geolocation.Default);
        builder.Services.AddSingleton<IMap>(Map.Default);

        builder.Services.AddSingleton<IAppleAuthService, AppleAuthService>();
        builder.Services.AddSingleton<IAuthService, FacebookAuthService>();
        builder.Services.AddSingleton<IQuestionService, MockQuestionService>();
        return builder.Build();
	}
}

