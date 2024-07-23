//https://www.youtube.com/watch?v=DuNLR_NJv8U 1:32:02 22

using Microsoft.Extensions.Logging;
using MonkeyFinder.View;

namespace MonkeyFinder;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<MainPage>();

		return builder.Build();
	}
}
