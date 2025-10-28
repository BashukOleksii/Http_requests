using SubscriptionManager.Core.Models;

namespace SubscriptionManager.API.IServices
{
    public interface ISubService
    {

            Task CreateAsync(SubscriptionItem element);
            Task<IEnumerable<SubscriptionItem>> GetAllAsync();
            Task<SubscriptionItem> GetByIdAsync(string id);
            Task DeleteAsync(string id);
            Task UpdateAsync(string id, SubscriptionItem element);
    }
}
