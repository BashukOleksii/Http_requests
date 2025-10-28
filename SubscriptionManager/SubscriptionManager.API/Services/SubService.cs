using SubscriptionManager.API.IServices;
using SubscriptionManager.Core.Interfaces;
using SubscriptionManager.Core.Models;

namespace SubscriptionManager.API.Services
{
    public class SubService : ISubService
    {
        private readonly ISubRepository _subRepository;
        private readonly IPeopleRepository _peopleRepository;

        public SubService(ISubRepository subRepository, IPeopleRepository peopleRepository)
        {
            _subRepository = subRepository;
            _peopleRepository = peopleRepository;
        }

        public Task CreateAsync(SubscriptionItem element)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SubscriptionItem>> GetAllAsync()
        {
            var subs = await _subRepository.GetAllAsync();

            if (subs is null || !subs.Any())
                throw new KeyNotFoundException("Не знайдено підпски");

            return subs;
        }
       

        public Task<SubscriptionItem> GetByIdAsync(string id)
        {
            var sub = _subRepository.GetByIdAsync(id);
            if (sub is null)
                throw new KeyNotFoundException($"Не знайдено користувача за вказаним id {id}");

            return sub;
        }

        public Task UpdateAsync(string id, SubscriptionItem element)
        {
            throw new NotImplementedException();
        }
    }
}
