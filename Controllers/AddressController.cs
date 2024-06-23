using AddressValidation.Services;
using Microsoft.AspNetCore.Mvc;

namespace AddressValidation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AddressController : Controller
    {
        private readonly ValidateAddressService _validateAddressService;
        public AddressController(ValidateAddressService validateAddressService)
        {
            _validateAddressService = validateAddressService;
        }

        [Route("Validate")]
        [HttpPost]
        public bool Validate([FromBody] string address)
        {
            return _validateAddressService.Validate(address);
        }

    }
}
