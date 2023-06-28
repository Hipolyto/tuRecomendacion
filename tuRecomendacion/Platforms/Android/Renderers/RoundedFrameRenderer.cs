using Android.Content;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform;
using System.ComponentModel;
using tuRecomendacion.Controls;

namespace tuRecomendacion.Renderers
{
    public partial class RoundedFrameRenderer : FrameRenderer
    {
        public RoundedFrameRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement == null)
                return;
            if (Element is RoundedFrame roundedFrame)
                Control.Radius = roundedFrame.Rounded;
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if(e.PropertyName == RoundedFrame.RoundedProperty.PropertyName)
            {
                if (Element is RoundedFrame roundedFrame)
                    Control.Radius = roundedFrame.Rounded;
            }
            if (e.PropertyName == Frame.CornerRadiusProperty.PropertyName)
            {
                
            }
        }
    }
}
