using tuRecomendacion.Controls;
using Microsoft.Maui.Handlers;

namespace tuRecomendacion.Handlers
{
    public partial class CustomEntryHandler
    {
        public CustomEntryHandler() : base(PropertyMapper)
        {
        }
        public static PropertyMapper<CustomEntry, CustomEntryHandler> PropertyMapper = new(ViewHandler.ViewMapper)
        {
            [nameof(CustomEntry.Text)] = MapText,
            [nameof(CustomEntry.TextColor)] = MapTextColor
        };
    }
}
