using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuRecomendacion.Controls
{
    public class RoundedFrame : Frame
    {
        public float Rounded
        {
            get => (float)GetValue(RoundedProperty);
            set => SetValue(RoundedProperty, value);
        }
        public static readonly BindableProperty RoundedProperty =
            BindableProperty.Create(
               nameof(Rounded),
               typeof(float),
               typeof(RoundedFrame),
               0f);
    }
}
