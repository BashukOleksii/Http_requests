using MongoDB.Driver;
using SubscriptionManager.Core;
using SubscriptionManager.Core.Interfaces;
using SubscriptionManager.Core.Models;

namespace SubscriptionManager.API.Repositories
{
    public class PeopleRepository : IPeopleRepository
    {
        private IMongoCollection<PeopleItem> _collection;
        public PeopleRepository()
        {
            _collection = MongoDBCLient.Instance.GetCollection<PeopleItem>("Peoples");
        }

        public async Task CreateAsync(PeopleItem item) =>
            await _collection.InsertOneAsync(item);
        
        public async Task DeletAsynce(string id) =>
            await _collection.DeleteOneAsync(x => x.Id == id);


        public async Task<IEnumerable<PeopleItem>> GetAllAsync() =>
            await _collection.Find(x => true).ToListAsync();

        public async Task<PeopleItem> GetByIdAsync(string id) =>
            await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();


        public async Task UpdateAsync(string id, PeopleItem item) =>
            await _collection.ReplaceOneAsync(x => x.Id == id, item);
    }
}
