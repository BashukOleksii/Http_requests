using MongoDB.Driver;
using SubscriptionManager.Core;
using SubscriptionManager.Core.Interfaces;
using SubscriptionManager.Core.Models;

namespace SubscriptionManager.API.Repositories
{
    public class SubRepository : ISubRepository
    {
        private readonly IMongoCollection<SubscriptionItem> _collection;

        public SubRepository()
        {
            _collection = MongoDBCLient.Instance.GetCollection<SubscriptionItem>("Subscriptions");
        }

        public async Task CreateAsync(SubscriptionItem element) =>
            await _collection.InsertOneAsync(element);

        public async Task DeletAsynce(string id) =>
           await _collection.DeleteOneAsync(x => x.Id == id);

        public async Task<IEnumerable<SubscriptionItem>> GetAllAsync() =>
            await _collection.Find(x => true).ToListAsync();


        public async Task<SubscriptionItem> GetByIdAsync(string id) =>
            await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();
        

        public async Task<bool> IsExist(string id)=>
            await _collection.Find(x => x.Id == id).AnyAsync();


        public async Task UpdateAsync(string id, SubscriptionItem item) =>
            await _collection.ReplaceOneAsync(x => x.Id == id, item);
        
    }
}
