using Android.Widget;
using Microsoft.Maui;
using Microsoft.Maui.Handlers;
using tuRecomendacion.Controls;

namespace tuRecomendacion.Handlers
{
    public partial class CustomLabelHandler : ViewHandler<CustomLabel, TextView>
    {
        protected override TextView CreatePlatformView()
        {
            // Crear una nueva instancia de TextView
            var textView = new TextView(MauiContext.Context);

            // Configurar la vista nativa según las propiedades de CustomLabel
            textView.Text = VirtualView?.Text;

            return textView;
        }

        public static void MapCommand(CustomLabelHandler handler, CustomLabel view)
        {
            if (handler.PlatformView != null && view.Command != null)
            {
                handler.PlatformView.Clickable = true;
                handler.PlatformView.Focusable = true;

                handler.PlatformView.Click += (sender, args) =>
                {
                    view.Command.Execute(null);
                };
            }
        }

        public static void MapIsUnderLine(CustomLabelHandler arg1, CustomLabel arg2)
        {
            throw new NotImplementedException();
        }


    }
}
