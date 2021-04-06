using Chat.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Domain.Interfaces.Repositories
{
    interface IMessageRepository
    {
        Task CreateAsync(MessageModel message);
        Task UpdateAsync(MessageModel message);
        Task DeleteAsync(string messageId);
        Task<MessageModel> GetByIdAsync(string messageId);
        Task<List<MessageModel>> ListByFilterAsync(DateTime? createdAt = null, bool? isActive = null);
    }
}
