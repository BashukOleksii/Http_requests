using SubscriptionManager.API.IServices;
using SubscriptionManager.Core.Interfaces;
using SubscriptionManager.Core.Models;
using System.Xml.Linq;

namespace SubscriptionManager.API.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _peopleRepository;

        public PeopleService(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }

        public Task CreateAsync(PeopleItem element)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PeopleItem>> GetAllAsync()
        {
            var peopleItems = await _peopleRepository.GetAllAsync();
           
            if (peopleItems.Count() == 0)
                throw new KeyNotFoundException("Не знайдено жодного користувача");

            return peopleItems;
        }

        public async Task<PeopleItem> GetByIdAsync(string id)
        {
            var people = await _peopleRepository.GetByIdAsync(id);

            if (people is null)
                throw new KeyNotFoundException($"Не знайдено користувача за Id {id}");

            return people;
        }

        public async Task<bool> IsExist(string id) =>
            await _peopleRepository.GetByIdAsync(id) is not null;
            
        public Task UpdateAsync(string id, PeopleItem element)
        {
            throw new NotImplementedException();
        }
    }
}
