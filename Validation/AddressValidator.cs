﻿using AddressValidation.Models;
using System.Text.RegularExpressions;

namespace AddressValidation.Validation
{
    public class AddressValidator : IAddressValidator
    {
        public void Validate(AddressNetherlands address)
        {
            var zipCodeRegex = new Regex("^[0-9]{4}[ ]*[A-Za-z]{2}$");

            if (!zipCodeRegex.IsMatch(address.Zipcode))
            {
                throw new Exception("Invalid zip code format");
            }

            return;
        }

        public void Validate(AddressUSA address)
        {
            return;
        }
    }
}
