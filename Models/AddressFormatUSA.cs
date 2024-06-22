using System.Text.Json.Serialization;

namespace AddressValidator.Models
{
    public class AddressFormatUSA
    {
        [JsonPropertyName("Country")]
        public required string CountryCode { get; set; }
        public string? StreetName { get; set; }
        public string? StreetNumber { get; set; }
        public string? Apartment { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
    }
}
