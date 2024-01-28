/*using AccessManagement.API.User.Application;
using AccessManagement.API.User.Infrustructure.Entites;

namespace AccessManagement.API.User.Application.Repository;
public class AddressRepository : IAddressRepository
{
    public async Task<List<Address>> GetAddressesByUserId(int userId)
    {
        return await _context.Addresses.Where(a => a.UserId == userId).ToListAsync();
    }

    public async Task<Address> GetAddressById(int addressId)
    {
        return await _context.Addresses.FindAsync(addressId);
    }

    public async Task<int> CreateAddress(Address newAddress)
    {
        _context.Addresses.Add(newAddress);
        await _context.SaveChangesAsync();
        return newAddress.AddressId;
    }

    public async Task UpdateAddress(Address updatedAddress)
    {
        _context.Addresses.Update(updatedAddress);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAddress(int addressId)
    {
        var addressToDelete = await _context.Addresses.FindAsync(addressId);
        if (addressToDelete != null)
        {
            _context.Addresses.Remove(addressToDelete);
            await _context.SaveChangesAsync();
        }
    }
}

*/