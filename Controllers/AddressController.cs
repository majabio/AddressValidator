using AddressValidation.Models;
using AddressValidation.Services;
using Microsoft.AspNetCore.Mvc;

namespace AddressValidation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AddressController(ValidateAddressService validateAddressService, GetAddressSchemaService getAddressSchemaService) : Controller
    {
        private readonly ValidateAddressService _validateAddressService = validateAddressService;
        private readonly GetAddressSchemaService _addressSchemaService = getAddressSchemaService;

        [Route("Validate")]
        [HttpPost]
        public IActionResult Validate([FromBody]string address)
        {
            var isValid = _validateAddressService.Validate(address);

            if (!isValid)
            {
                return BadRequest("Invalid address");
            }

            return Ok("Success");
        }

        [Route("{countryCode}")]
        [HttpGet]
        public IActionResult Get([FromRoute]CountryCode countryCode)
        {
            try
            {
                var schema = _addressSchemaService.GetSchema(countryCode);
                return Ok(schema.ToString());
            }
            catch (Exception) 
            {
                return BadRequest();
            }
        }
    }
}
