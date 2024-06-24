using AddressValidation.Models;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;

namespace AddressValidation
{
    public class JsonSchemaGenerator
    {
        public JSchema Generate(CountryCode countryCode)
        {
            return countryCode switch
            {
                CountryCode.NL => Generate<AddressNetherlands>(),
                CountryCode.US => Generate<AddressUSA>(),
                _ => throw new Exception(),
            };
        }

        private static JSchema Generate<T>()
        {
            JSchemaGenerator generator = new();
            return generator.Generate(typeof(T));
        }

    }
}
