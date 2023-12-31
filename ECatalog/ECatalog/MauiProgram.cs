﻿using Microcharts.Maui;
using Microsoft.Extensions.Logging;

namespace ECatalog
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMicrocharts()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "materii.db");

            builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<DaoMaterii>(s, dbPath));
            builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<DaoStudent>(s, dbPath));

            return builder.Build();
        }
    }
}
