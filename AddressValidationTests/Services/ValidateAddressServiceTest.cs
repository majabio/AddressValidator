using AddressValidation.Services;
using AddressValidation.Validation;
using AddressValidation;
using Moq;

namespace AddressValidationTests.Services
{
    public class ValidateAddressServiceTest
    {
        private readonly Mock<IAddressFactory> _addressFactoryMock = new();
        private readonly Mock<IAddressValidator> _addressValidatorMock = new();

        private readonly ValidateAddressService _validateAddressService;

        public ValidateAddressServiceTest()
        {
            _validateAddressService = new ValidateAddressService(_addressFactoryMock.Object, _addressValidatorMock.Object);
        }


        [TestCase]
        public void ExceptionIsThrownWhenThereIsCountryCodeMissing()
        {
            const string addressInput = "{\"City\": \"Amsterdam\", \"Street\" : \"Test street\", \"Zipcode\": \"1111AA\", \"HouseNumber\" : 1}";

            Assert.Throws<Exception>(() => _validateAddressService.Validate(addressInput));
        }
    }
}
