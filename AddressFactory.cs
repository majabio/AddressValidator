using AddressValidation.Models;
using System.Text.Json;

namespace AddressValidation
{
    public class AddressFactory : IAddressFactory
    {
        public IAddress Create(CountryCode countryCode, string address)
        {
            return countryCode switch
            {
                CountryCode.NL => Deserialize<AddressNetherlands>(address),
                CountryCode.US => Deserialize<AddressUSA>(address),
                _ => throw new Exception("Not supported country code"),
            };
        }

        private static IAddress Deserialize<T>(string address)
        {
            try
            {
                return JsonSerializer.Deserialize<T>(address) as IAddress;
            }
            catch(Exception)
            {
                throw new Exception("Invalid json input");
            }        
        }
    }
}
