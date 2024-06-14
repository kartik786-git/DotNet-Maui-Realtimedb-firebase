using Firebase.Database;
using Microsoft.Extensions.Logging;

namespace MauiAppRealtimedbwithfirebase
{
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
            builder.Services.AddSingleton(new FirebaseClient("https://maui-with-firebase-default-rtdb.firebaseio.com/"));


            builder.Services.AddSingleton<MainPage>();
            return builder.Build();
        }
    }
}
