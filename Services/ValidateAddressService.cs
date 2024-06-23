using AddressValidation.Models;
using Newtonsoft.Json.Linq;

namespace AddressValidation.Services
{
    public class ValidateAddressService(IAddressFactory addressFactory)
    {
        private readonly IAddressFactory _addressFactory = addressFactory;

        public bool Validate(string inputAddress)
        {
            JObject jsonAddress = JObject.Parse(inputAddress);
            var countryCode = jsonAddress["Country"];

            if (countryCode is null)
            {
                return false;
            }

            try
            {
                var address = _addressFactory.Create(countryCode.ToObject<CountryCode>(), inputAddress);
                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                //TODO:log error
                return false;
            }
        }

    }
}
