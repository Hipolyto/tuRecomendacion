using tuRecomendacion.Controls;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using UIKit;

namespace tuRecomendacion.Handlers
{
    public partial class CustomButtonHandler : ViewHandler<CustomButton, UIButton>
    {
        protected override UIButton CreatePlatformView() => new();
        protected override void ConnectHandler(UIButton platformView)
        {
            base.ConnectHandler(platformView);
        }
        protected override void DisconnectHandler(UIButton platformView)
        {
            platformView?.Dispose();
            base.DisconnectHandler(platformView);
        }
        public static void MapText(CustomButtonHandler handler, CustomButton button)
        {
            handler.PlatformView.TitleLabel.Text = button.Text;
        }
        public static void MapTextColor(CustomButtonHandler handler, CustomButton button)
        {
            handler.PlatformView.TitleLabel.TextColor = button.TextColor.ToPlatform();
        }
    }
}
