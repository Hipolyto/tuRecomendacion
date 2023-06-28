using Android.Content;
using AndroidX.AppCompat.Widget;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using tuRecomendacion.Controls;

namespace tuRecomendacion.Handlers
{
    public partial class CustomEntryHandler : ViewHandler<CustomEntry, AppCompatEditText>
    {
        protected override AppCompatEditText CreatePlatformView() => new(Context);
        protected override void ConnectHandler(AppCompatEditText platformView)
        {
            base.ConnectHandler(platformView);
        }
        protected override void DisconnectHandler(AppCompatEditText platformView)
        {
            platformView?.Dispose();
            base.DisconnectHandler(platformView);
        }
        public static void MapText(CustomEntryHandler handler, CustomEntry entry)
        {
            handler.PlatformView.Text = entry.Text;
            handler?.PlatformView?.SetSelection(handler.PlatformView?.Text?.Length ?? 0);
        }
        public static void MapTextColor(CustomEntryHandler handler, CustomEntry entry)
        {
            handler.PlatformView?.SetTextColor(entry.TextColor.ToPlatform());
        }
    }
}
