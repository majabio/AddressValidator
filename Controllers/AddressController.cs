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
            try
            {
                _validateAddressService.Validate(address);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
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
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
