using AddressValidation.Models;

namespace AddressValidation
{
    public class AddressFactory : IAddressFactory
    {
        public IAddress Create(CountryCode countryCode, string address)
        {
            switch (countryCode)
            {
                case CountryCode.NL:
                    return new AddressNetherlands();
                case CountryCode.US:
                    return new AddressUSA();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
