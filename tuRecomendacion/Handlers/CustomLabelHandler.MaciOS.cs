#nullable enable
using UIKit;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Handlers;
using tuRecomendacion.Controls;
using Foundation;
using static System.Net.Mime.MediaTypeNames;

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

        public static void MapIsUnderLine(CustomLabelHandler handler, CustomLabel customLabel)
        {
            if (customLabel.IsUnderLine)
            {
                handler.PlatformView.UserInteractionEnabled = true;
                var underlineAttribute = new UIStringAttributes
                {
                    UnderlineStyle = NSUnderlineStyle.Thick
                };
                var underlineAttributedString = new NSAttributedString(customLabel.Text, underlineAttribute);
                handler.PlatformView.AttributedText = underlineAttributedString;
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

