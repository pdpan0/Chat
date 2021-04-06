using Chat.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Domain.Interfaces.Repositories
{
    interface IChatRepository
    {
        Task CreateAsync(ChatModel chat);
        Task UpdateAsync(ChatModel chat);
        Task DeleteAsync(string chatId);
        Task<ChatModel> GetByIdAsync(string chatId);
        Task<List<ChatModel>> ListByFilterAsync(DateTime? createdAt = null, bool? isActive = null);
    }
}
