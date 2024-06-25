using AddressValidation.Models;

namespace AddressValidation.Validation
{
    public interface IAddressValidator
    {
        public void Validate(AddressNetherlands address);
        public void Validate(AddressUSA address);
    }
}
