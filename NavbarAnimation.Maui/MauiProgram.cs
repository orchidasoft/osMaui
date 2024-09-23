using Microsoft.Maui.Platform;
using SimpleToolkit.Core;
using SimpleToolkit.SimpleShell;

namespace NavbarAnimation.Maui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
#if ANDROID
         Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUndeline", (h, v) =>
        {
            h.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
        });
#endif

        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Bold.ttf", "OpenSansBold");
                fonts.AddFont("OpenSans-Light.ttf", "OpenSansLight");
                fonts.AddFont("OpenSans-Medium.ttf", "OpenSansMedium");
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Comfortaa-Regular.ttf", "RegularFont");
                fonts.AddFont("Comfortaa-Bold.ttf", "BoldFont");
                fonts.AddFont("Comfortaa-Medium.ttf", "MediumFont");
                fonts.AddFont("Comfortaa-SemiBold.ttf", "SemiBoldFont");
                fonts.AddFont("materialdesignicons-webfont.ttf", "materialdesignicons");


            })
            .UseSimpleToolkit()
            .UseSimpleShell();

#if ANDROID || IOS
        builder.DisplayContentBehindBars();
#endif

        return builder.Build();
    }
}