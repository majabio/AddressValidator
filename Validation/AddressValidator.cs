using AddressValidation.Models;

namespace AddressValidation.Validation
{
    public class AddressValidator : IAddressValidator
    {
        public bool Validate(AddressNetherlands address)
        {
            return true;
        }

        public bool Validate(AddressUSA address)
        {
            return true;
        }
    }
}
