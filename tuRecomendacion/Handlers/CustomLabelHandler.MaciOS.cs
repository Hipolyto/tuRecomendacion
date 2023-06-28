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
        public static void MapCommand(CustomLabelHandler handler, CustomLabel view)
        {
            if (handler.PlatformView != null && view.Command != null)
            {
                handler.PlatformView.UserInteractionEnabled = true;
                var tapGestureRecognizer = new UITapGestureRecognizer(() =>
                {
                    view.Command.Execute(null);
                });

                handler.PlatformView.AddGestureRecognizer(tapGestureRecognizer);
            }
        }

        protected override UILabel CreatePlatformView()
        {
            var lbl = new UILabel();
            lbl.Text = VirtualView?.Text;
            return lbl;
        }
    }
}

