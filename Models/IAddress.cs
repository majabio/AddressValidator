using AddressValidation.Validation;

namespace AddressValidation.Models
{
    public interface IAddress
    {
        public void Validate(IAddressValidator addressValidator);
    }
}
