using Chat.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chat.Domain.Interfaces.Repositories
{
    interface IDoctorsRepository
    {
        Task CreateAsync(DoctorModel doctor);
        Task UpdateAsync(DoctorModel doctor);
        Task DeleteAsync(string doctorId);
        Task<DoctorModel> GetByIdAsync(string doctorId);
        Task<List<DoctorModel>> ListByFilterAsync(string doctorId = null, string name = null);
    }
}
