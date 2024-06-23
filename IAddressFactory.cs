using AddressValidation.Models;

namespace AddressValidation
{
    public interface IAddressFactory
    {
        public IAddress Create(CountryCode countryCode, string address);
    }
}
