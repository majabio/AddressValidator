using AddressValidation.Models;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;

namespace AddressValidation
{
    public class JsonSchemaFactory
    {
        public JSchema Create(CountryCode countryCode)
        {
            return countryCode switch
            {
                CountryCode.NL => Create<AddressNetherlands>(),
                CountryCode.US => Create<AddressUSA>(),
                _ => throw new Exception("Not supported country code"),
            };
        }

        private static JSchema Create<T>()
        {
            JSchemaGenerator generator = new();
            return generator.Generate(typeof(T));
        }

    }
}
