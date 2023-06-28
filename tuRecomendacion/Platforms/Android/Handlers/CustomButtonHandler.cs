using AndroidX.AppCompat.Widget;
using tuRecomendacion.Controls;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace tuRecomendacion.Handlers
{
    public partial class CustomButtonHandler : ViewHandler<CustomButton, AppCompatButton>
    {
        protected override AppCompatButton CreatePlatformView() => new(Context);
        protected override void ConnectHandler(AppCompatButton platformView)
        {
            base.ConnectHandler(platformView);
        }
        protected override void DisconnectHandler(AppCompatButton platformView)
        {
            platformView?.Dispose();
            base.DisconnectHandler(platformView);
        }
        public static void MapText(CustomButtonHandler handler, CustomButton button)
        {
            handler.PlatformView.Text = button.Text;
        }
        public static void MapTextColor(CustomButtonHandler handler, CustomButton button)
        {
            handler.PlatformView?.SetTextColor(button.TextColor.ToPlatform());
        }
    }
}
