using MediSmartsAPI.Model;
using MediSmartsAPI.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediSmartsAPI.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly DataContext _dataContext;

        public RegistrationService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public  async Task<bool> CreateUserAsync(Registration user)
        {
            await _dataContext.Registrations.AddAsync(user);
            var created = await _dataContext.SaveChangesAsync();
            return created > 0;
        }

        public async Task<bool> DeleteUserAsync(Guid userId)
        {
            var user = await GetUserByIdAsync(userId);
            if (user == null)
                return false;
            _dataContext.Registrations.Remove(user);
            var deleted = await _dataContext.SaveChangesAsync();

            return deleted > 0;
        }

        public async Task<List<Registration>> GetUserAsync()
        {
            return await _dataContext.Registrations.ToListAsync();
        }

        public async Task<Registration> GetUserByIdAsync(Guid userId)
        {
            return await _dataContext.Registrations.SingleOrDefaultAsync(x => x.Id == userId);
        }

        public async Task<bool> UpdateUserAsync(Registration userToUpdate)
        {
            _dataContext.Registrations.Update(userToUpdate);
            var updated = await _dataContext.SaveChangesAsync();
            return updated > 0;
        }
    }
}
