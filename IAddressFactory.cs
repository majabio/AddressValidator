using AddressValidator.Models;

namespace AddressValidator
{
    public interface IAddressFactory
    {
        public IAddress Create(CountryCode countryCode, string address);
    }
}
