using SubscriptionManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionManager.Core.Interfaces
{
    public interface IPeopleRepository
    {
        Task<IEnumerable<PeopleItem>> GetAllAsync();
        Task<PeopleItem> GetByIdAsync(string id);
        Task CreateAsync(PeopleItem  item);
        Task UpdateAsync(string id, PeopleItem item);
        Task DeletAsynce(string id);

        Task<bool> IsExist(string id);
    }
}
