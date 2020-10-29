using MediSmartsAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediSmartsAPI.Services
{
    public interface IRegistrationService
    {
        Task<List<Registration>> GetUserAsync();

        Task<Registration> GetUserByIdAsync(Guid userId);
        Task<bool> CreateUserAsync(Registration user);

        Task<bool> UpdateUserAsync(Registration userToUpdate);

        Task<bool> DeleteUserAsync(Guid userId);

    }
}
