#nullable enable
using UIKit;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Handlers;
using tuRecomendacion.Controls;

namespace tuRecomendacion.Handlers
{
    public partial class CustomLabelHandler : ViewHandler<CustomLabel, UILabel>
    {
        public CustomLabelHandler(IPropertyMapper mapper, CommandMapper commandMapper = null) : base(mapper, commandMapper)
        {
        }

        public static void MapCommand(LabelHandler handler, CustomLabel view)
        {
            var st = handler?.PlatformView;
           // var nativeLabel = (UILabel)handler.PlatformView .NativeView;

            // Aquí tendrías la lógica específica para manejar el cambio en la propiedad Command en iOS.
        }

        protected override UILabel CreatePlatformView()
        {
            return new UILabel();
        }

        protected override void ConnectHandler(UILabel platformView)
        {
            base.ConnectHandler(platformView);

            // Perform any control setup here
        }

        protected override void DisconnectHandler(UILabel platformView)
        {
            platformView.Dispose();
            base.DisconnectHandler(platformView);
        }
    }
}

