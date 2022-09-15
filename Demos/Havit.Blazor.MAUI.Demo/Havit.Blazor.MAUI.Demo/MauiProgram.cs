using Microsoft.AspNetCore.Components.WebView.Maui;
using Havit.Blazor.MAUI.Demo.Data;
using Havit.Blazor.Components.Web;

namespace Havit.Blazor.MAUI.Demo;

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
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		#endif

		builder.Services.AddHxServices();
		builder.Services.AddHxMessenger();

		builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}

