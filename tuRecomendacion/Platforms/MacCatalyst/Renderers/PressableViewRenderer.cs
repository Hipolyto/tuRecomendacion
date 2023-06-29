using Foundation;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using tuRecomendacion.Controls;
using UIKit;

namespace tuRecomendacion.Renderers
{
    public partial class PressableViewRenderer : VisualElementRenderer<PressableView>
    {
        public PressableViewRenderer() 
        {
            this.UserInteractionEnabled = true;
        }
        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            base.TouchesBegan(touches, evt);
            Element?.RaisePressed();
        }
        public override void TouchesCancelled(NSSet touches, UIEvent evt)
        {
            base.TouchesCancelled(touches, evt);
            Element?.RaiseReleased();
        }
        public override void TouchesEnded(NSSet touches, UIEvent evt)
        {
            base.TouchesEnded(touches, evt);
            Element?.RaiseReleased();
        }
    }
}
