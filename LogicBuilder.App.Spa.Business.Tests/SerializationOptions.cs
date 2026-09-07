using LogicBuilder.App.Utils.Json;
using LogicBuilder.Domain.Json;
using System.Text.Json;

namespace LogicBuilder.App.Spa.Business.Tests
{
    public static class SerializationOptions
    {
        private static JsonSerializerOptions? _default;
        public static JsonSerializerOptions Default
        {
            get
            {
                if (_default != null)
                    return _default;

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                options.Converters.Add(new ModelConverter());
                options.Converters.Add(new ObjectConverter());

                _default = options;

                return _default;
            }
        }
    }
}
