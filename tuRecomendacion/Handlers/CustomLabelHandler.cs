using Microsoft.Maui.Handlers;
using tuRecomendacion.Controls;
#if IOS || MACCATALYST
using PlatformView = tuRecomendacion.Controls;
#elif ANDROID
using PlatformView = tuRecomendacion.Controls;
#elif WINDOWS
using PlatformView = VideoDemos.Platforms.Windows.MauiVideoPlayer;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID)
using PlatformView = System.Object;
#endif

namespace tuRecomendacion.Handlers
{
    public partial class CustomLabelHandler
    {
        public static IPropertyMapper<CustomLabel, CustomLabelHandler> PropertyMapper = new PropertyMapper<CustomLabel, CustomLabelHandler>(CustomLabelHandler.ViewMapper)
        {
            [nameof(CustomLabel.Command)] = MapCommand,
            [nameof(CustomLabel.IsUnderLine)] = MapIsUnderLine
        };

        public CustomLabelHandler() : base(PropertyMapper)
        {
        }
    }
}
