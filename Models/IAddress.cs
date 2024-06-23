using AddressValidation.Validation;

namespace AddressValidation.Models
{
    public interface IAddress
    {
        public bool Validate(IAddressValidator addressValidator);
    }
}
