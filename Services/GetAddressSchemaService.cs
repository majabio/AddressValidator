using AddressValidation.Models;
using Newtonsoft.Json.Schema;

namespace AddressValidation.Services
{
    public class GetAddressSchemaService(JsonSchemaFactory jsonSchemaFactory)
    {
        private readonly JsonSchemaFactory _jsonSchemaFactory = jsonSchemaFactory;

        public JSchema GetSchema(CountryCode countryCode)
        {
            return _jsonSchemaFactory.Create(countryCode);
        }
    }
}
