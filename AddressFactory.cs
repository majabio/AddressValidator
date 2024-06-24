using AddressValidation.Models;
using System.Text.Json;

namespace AddressValidation
{
    public class AddressFactory : IAddressFactory
    {
        public IAddress Create(CountryCode countryCode, string address)
        {
            switch (countryCode)
            {
                case CountryCode.NL:
                    return Deserialize<AddressNetherlands>(address);
                case CountryCode.US:
                    return Deserialize<AddressUSA>(address);
                default:
                    throw new Exception();
            }
        }

        private static IAddress Deserialize<T>(string address)
        {
            try
            {
                return JsonSerializer.Deserialize<T>(address) as IAddress;
            }
            catch(Exception)
            {
                throw new Exception();
            }        
        }
    }
}
