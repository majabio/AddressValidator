using AddressValidation.Models;
using AddressValidation.Validation;
using Newtonsoft.Json.Linq;

namespace AddressValidation.Services
{
    public class ValidateAddressService(IAddressFactory addressFactory, IAddressValidator validator)
    {
        private readonly IAddressFactory _addressFactory = addressFactory;
        private readonly IAddressValidator _validator = validator;

        public void Validate(string inputAddress)
        {
            JObject jsonAddress = JObject.Parse(inputAddress);
            var countryCode = jsonAddress["Country"];

            if (countryCode is null)
            {
                throw new Exception("Missing country code");
            }


            var address = _addressFactory.Create(countryCode.ToObject<CountryCode>(), inputAddress);
            address.Validate(_validator);
        }

    }
}
