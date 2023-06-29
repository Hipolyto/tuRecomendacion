using Microsoft.Maui.Handlers;
using tuRecomendacion.Controls;

namespace tuRecomendacion.Handlers
{
    public partial class CustomButtonHandler
    {
        public CustomButtonHandler() : base(PropertyMapper)
        {
        }
        public static PropertyMapper<CustomButton, CustomButtonHandler> PropertyMapper = new(ViewHandler.ViewMapper)
        {
            [nameof(CustomButton.Text)] = MapText,
            [nameof(CustomButton.TextColor)] = MapTextColor
        };
    }
}
