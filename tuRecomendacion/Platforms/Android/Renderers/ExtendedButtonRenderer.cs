
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuRecomendacion.Renderers
{
    public partial class ExtendedButtonRenderer : ButtonHandler
    {
        public static new void MapText(IButtonHandler handler, IText button)
        {
            handler.PlatformView.Text = button.Text;
        }
    }
}
