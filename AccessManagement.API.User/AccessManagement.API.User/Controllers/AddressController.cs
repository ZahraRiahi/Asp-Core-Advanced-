/*using AccessManagement.API.User.Application.Repository;
using AccessManagement.API.User.Infrustructure.Entites;
using Microsoft.AspNetCore.Mvc;

namespace AccessManagement.API.User.Controllers;

[ApiController]
[Route("[controller]")]
public class AddressController : ControllerBase
{
    private readonly AddressRepository _addressRepository;
    public AddressController(AddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }
    [HttpGet("user/{userId}")]
    public async Task<ActionResult<List<Address>>> GetAddressesByUserId(int userId)
    {
        var addresses = await _addressRepository.GetAddressesByUserId(userId);
        return Ok(addresses);
    }

    [HttpGet("{addressId}")]
    public async Task<ActionResult<Address>> GetAddressById(int addressId)
    {
        var address = await _addressRepository.GetAddressById(addressId);
        if (address == null)
            return NotFound();

        return Ok(address);
    }

    [HttpPost]
    public async Task<ActionResult<int>> CreateAddress([FromBody] Address newAddress)
    {
        var addressId = await _addressRepository.CreateAddress(newAddress);
        return Ok(addressId);
    }

    [HttpPut("{addressId}")]
    public async Task<ActionResult> UpdateAddress(Guid addressId, [FromBody] Address updatedAddress)
    {
        if (addressId != updatedAddress.AddressID)
            return BadRequest();

        await _addressRepository.UpdateAddress(updatedAddress);
        return NoContent();
    }

    [HttpDelete("{addressId}")]
    public async Task<ActionResult> DeleteAddress(int addressId)
    {
        await _addressRepository.DeleteAddress(addressId);
        return NoContent();
    }
}*/