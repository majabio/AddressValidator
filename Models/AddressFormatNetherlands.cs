using System.Text.Json.Serialization;

namespace AddressValidator.Models
{
    public class AddressFormatNetherlands
    {
        [JsonPropertyName("Country")]
        public required string CountryCode { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public required string Zipcode { get; set; }
        public int HouseNumber { get; set; }
    }
}
