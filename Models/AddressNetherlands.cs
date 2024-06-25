using AddressValidation.Validation;
using Newtonsoft.Json;

namespace AddressValidation.Models
{
    public class AddressNetherlands : IAddress
    {
        [JsonProperty(Required = Required.Default)]
        public string? City { get; set; }

        [JsonProperty(Required = Required.Default)]
        public string? Street { get; set; }
        public required string Zipcode { get; set; }
        public required int HouseNumber { get; set; }

        public void Validate(IAddressValidator addressValidator)
        {
            addressValidator.Validate(this);
        }
    }
}
