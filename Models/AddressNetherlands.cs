using AddressValidation.Validation;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

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

        public bool Validate(IAddressValidator addressValidator)
        {
            return addressValidator.Validate(this);
        }
    }
}
