using System.ComponentModel;
using tuRecomendacion.Controls;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform;

namespace tuRecomendacion.Renderers
{
    public partial class RoundedFrameRenderer : FrameRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement == null)
                return;
            if (Element is RoundedFrame roundedFrame)
            {
                this.Layer.CornerRadius = roundedFrame.Rounded;
            }
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == RoundedFrame.CornerRadiusProperty.PropertyName)
            {
                if (Element is RoundedFrame roundedFrame)
                {
                    this.Layer.CornerRadius = roundedFrame.Rounded;
                }
            }
        }
    }
}
