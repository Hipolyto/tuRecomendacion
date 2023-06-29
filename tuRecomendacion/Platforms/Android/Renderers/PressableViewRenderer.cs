using Android.Content;
using Android.Views;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using tuRecomendacion.Controls;

namespace tuRecomendacion.Renderers
{
    public partial class PressableViewRenderer : VisualElementRenderer<PressableView>
    {
        public PressableViewRenderer(Context context) : base(context)
        {
            this.Touch += Control_Touch;
        }
        private void Control_Touch(object sender, TouchEventArgs e)
        {
            switch(e.Event.Action)
            {
                case MotionEventActions.Up:
                    Element?.RaiseReleased();
                    break;
                case MotionEventActions.Down:
                    Element?.RaisePressed();
                    break;
                default:
                    break;
            }
        }
    }
}
