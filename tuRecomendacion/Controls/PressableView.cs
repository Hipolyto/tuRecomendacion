using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuRecomendacion.Controls
{
    public class PressableView : ContentView
    {
        public event EventHandler Pressed;
        public event EventHandler Released;

        public bool IsPressable => Pressed != null || Released != null;

        public PressableView()
        {
        }

        public void RaisePressed() => Pressed?.Invoke(this, EventArgs.Empty);
        public void RaiseReleased() => Released?.Invoke(this, EventArgs.Empty);
    }
}
