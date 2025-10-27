using SubscriptionManager.Core.Models;

namespace SubscriptionManager.API.IServices
{
    public interface IPeopleService
    {
        Task CreateAsync(PeopleItem element);
        Task<IEnumerable<PeopleItem>> GetAllAsync();
        Task<PeopleItem> GetByIdAsync(string id);
        Task DeleteAsync(string id);
        Task UpdateAsync(string id, PeopleItem element);
        Task<bool> IsExist(string id);
    }
}
