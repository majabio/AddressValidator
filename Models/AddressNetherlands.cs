using AddressValidation.Validation;

namespace AddressValidation.Models
{
    public class AddressNetherlands : IAddress
    {
        public string? City { get; set; }
        public string? Street { get; set; }
        public required string Zipcode { get; set; }
        public required int HouseNumber { get; set; }

        public bool Validate(IAddressValidator addressValidator)
        {
            return addressValidator.Validate(this);
        }
    }
}
