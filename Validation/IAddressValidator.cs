using AddressValidation.Models;

namespace AddressValidation.Validation
{
    public interface IAddressValidator
    {
        public bool Validate(AddressNetherlands address);
        public bool Validate(AddressUSA address);
    }
}
