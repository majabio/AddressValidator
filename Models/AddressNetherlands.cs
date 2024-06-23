namespace AddressValidator.Models
{
    public class AddressNetherlands : IAddress
    {
        public string? CountryCode { get; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? Zipcode { get; set; }
        public int HouseNumber { get; set; }
    }
}
