using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using tuRecomendacion.Controls;

namespace tuRecomendacion.Handlers
{
    public partial class CustomEntryHandler : ViewHandler<CustomEntry, MauiTextField>
    {
        protected override MauiTextField CreatePlatformView() => new MauiTextField();
        
        protected override void ConnectHandler(MauiTextField platformView)
        {
            base.ConnectHandler(platformView);
        }
        protected override void DisconnectHandler(MauiTextField platformView)
        {
            platformView?.Dispose();
            base.DisconnectHandler(platformView);
        }
        public static void MapText(CustomEntryHandler handler, CustomEntry entry)
        {
            handler.PlatformView.Text = entry.Text;
            //handler?.PlatformView?selection (handler.PlatformView?.Text?.Length ?? 0);
        }
        public static void MapTextColor(CustomEntryHandler handler, CustomEntry entry)
        {
            handler.PlatformView.TextColor = entry.TextColor.ToPlatform();
        }
    }
}
