using Microsoft.Maui.Controls;
using System.Windows.Input;

namespace tuRecomendacion.Controls
{
    public class CustomLabel : Label
    {
        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(CustomLabel), default(ICommand));

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }
    }
}
