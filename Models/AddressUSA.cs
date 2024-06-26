﻿using AddressValidation.Validation;

namespace AddressValidation.Models
{
    public class AddressUSA : IAddress
    {
        public string? StreetName { get; set; }
        public string? StreetNumber { get; set; }
        public string? Apartment { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }

        public void Validate(IAddressValidator addressValidator)
        {
            addressValidator.Validate(this);
        }
    }
}
