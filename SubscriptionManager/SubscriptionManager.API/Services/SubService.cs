using SubscriptionManager.API.IServices;
using SubscriptionManager.Core.Interfaces;
using SubscriptionManager.Core.Models;

namespace SubscriptionManager.API.Services
{
    public class SubService : ISubService
    {

        private readonly IPeopleRepository _peopleRepository;
        private readonly ISubRepository _subRepository;

        public SubService(IPeopleRepository peopleRepository, ISubRepository subRepository)
        {
            _peopleRepository = peopleRepository;
            _subRepository = subRepository;
        }


        public async Task CreateAsync(SubscriptionItem element) {

            if (!await _peopleRepository.IsExist(element.OwnerId))
                throw new ArgumentException($"Не правильний власник підписки, його не існує за таким id {element.OwnerId}!");

            await _subRepository.CreateAsync(element);
        }
        


        public async Task DeleteAsync(string id)
        {
            if (!await _subRepository.IsExist(id))
                throw new KeyNotFoundException($"Не знайдено підписки з вказаним id: {id}");

            await _subRepository.DeletAsynce(id);
        }

        public async Task<IEnumerable<SubscriptionItem>> GetAllAsync()
        {
            var subs = await _subRepository.GetAllAsync();

            if (subs is null || !subs.Any())

                throw new KeyNotFoundException("Немає підписок в списку");

            return subs;
        }
        

        public async Task<SubscriptionItem> GetByIdAsync(string id)
        {

            var sub = await _subRepository.GetByIdAsync(id);

            if (sub is null)
                throw new KeyNotFoundException($"Не знайдено підписки з вказаним id: {id}");

            return sub;
        }
        


        public async Task UpdateAsync(string id, SubscriptionItem element)
        {
            if (!await _subRepository.IsExist(id))
                throw new KeyNotFoundException($"Не знайдено елемент завказанм id {id}");

            if(!await _peopleRepository.IsExist(element.OwnerId))
                throw new ArgumentException($"Невірний власник для підписки");

            await _subRepository.UpdateAsync(id, element);
        }
    }
}
