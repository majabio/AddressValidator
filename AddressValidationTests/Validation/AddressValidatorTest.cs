using AddressValidation.Models;
using AddressValidation.Validation;

namespace AddressValidationTests.Validation
{
    public class AddressValidatorTest
    {
        private readonly AddressValidator addressValidator = new();

        [TestCase]
        public void ValidateNLAddressThrowsIfZipCodeIsNotValidFormat()
        {
            var address = new AddressNetherlands() { Zipcode = "test", HouseNumber = 1 };

            Assert.Throws<Exception>(() => addressValidator.Validate(address));
        }

        [TestCase]
        public void ValidateNLAddressDoesNotThrowIfAddressIsValidFormatWithNoSpaceInZipcode()
        {
            var address = new AddressNetherlands() { Zipcode = "1111CA", HouseNumber = 1 };

            Assert.DoesNotThrow(() => addressValidator.Validate(address));
        }


        [TestCase]
        public void ValidateNLAddressDoesNotThrowIfAddressIsValidFormatWithSpaceInZipcode()
        {
            var address = new AddressNetherlands() { Zipcode = "1111 CA", HouseNumber = 1 };

            Assert.DoesNotThrow(() => addressValidator.Validate(address));
        }


    }
}
