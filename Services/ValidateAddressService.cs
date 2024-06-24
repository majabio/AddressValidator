using AddressValidation.Models;
using AddressValidation.Validation;
using Newtonsoft.Json.Linq;

namespace AddressValidation.Services
{
    public class ValidateAddressService(IAddressFactory addressFactory, IAddressValidator validator)
    {
        private readonly IAddressFactory _addressFactory = addressFactory;
        private readonly IAddressValidator _validator = validator;

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
                return address.Validate(_validator);
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
