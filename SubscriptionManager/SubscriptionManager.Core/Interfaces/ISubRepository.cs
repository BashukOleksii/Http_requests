using SubscriptionManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionManager.Core.Interfaces
{
    public interface ISubRepository
    {
        Task<IEnumerable<SubscriptionItem>> GetAllAsync();
        Task<SubscriptionItem> GetByIdAsync(string id);
        Task CreateAsync(SubscriptionItem item);
        Task UpdateAsync(string id, SubscriptionItem item);
        Task DeletAsynce(string id);

        Task<bool> IsExist(string id);
    }
}
