using AddressValidation.Models;
using System.Text.RegularExpressions;

namespace AddressValidation.Validation
{
    public class AddressValidator : IAddressValidator
    {
        public bool Validate(AddressNetherlands address)
        {
            var regex = new Regex("^[0-9]{4}[A-Z]{2}$");

            if (!regex.IsMatch(address.Zipcode))
                return false;

            return true;
        }

        public bool Validate(AddressUSA address)
        {
            return true;
        }
    }
}
