using AddressValidation.Models;
using Newtonsoft.Json.Schema;

namespace AddressValidation.Services
{
    public class GetAddressSchemaService(JsonSchemaGenerator jsonSchemaGenerator)
    {
        private readonly JsonSchemaGenerator _jsonSchemaGenerator = jsonSchemaGenerator;

        public JSchema GetSchema(CountryCode countryCode)
        {
            return _jsonSchemaGenerator.Generate(countryCode);
        }
    }
}
