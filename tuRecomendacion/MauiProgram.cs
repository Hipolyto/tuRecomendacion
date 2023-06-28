using System.Reflection.PortableExecutable;
using Microsoft.Extensions.Logging;
using tuRecomendacion.Controls;
using tuRecomendacion.Interfaces;
using tuRecomendacion.Services;
using tuRecomendacion.ViewModels;
using tuRecomendacion.Views;
using tuRecomendacion.Handlers;
using tuRecomendacion.Renderers;

namespace tuRecomendacion;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureMauiHandlers(handlers =>
			{
				handlers.AddHandler(typeof(CustomEntry), typeof(CustomEntryHandler));
                handlers.AddHandler(typeof(CustomButton), typeof(CustomButtonHandler));
                handlers.AddHandler(typeof(PressableView), typeof(PressableViewRenderer));
                handlers.AddHandler(typeof(RoundedFrame), typeof(RoundedFrameRenderer));

            })
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

