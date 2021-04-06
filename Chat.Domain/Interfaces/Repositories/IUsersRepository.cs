using Chat.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chat.Domain.Interfaces.Repositories
{
    interface IUsersRepository
    {
        Task CreateAsync(UserModel user);
        Task UpdateAsync(UserModel user);
        Task DeleteAsync(string userId);
        Task<UserModel> GetByIdAsync(string userId);
        Task<List<UserModel>> ListByFilterAsync(string userId = null, string name = null);
    }
}
