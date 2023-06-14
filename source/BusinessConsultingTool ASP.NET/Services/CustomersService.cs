using BusinessConsultingTool.DataAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BusinessConsultingTool.DataAPI.Services
{
    public class CustomersService
    {
        private readonly IMongoCollection<Customer> _customerCollection;

        public CustomersService(IOptions<BCTDatabaseSettings> bctDatabaseSettings)
        {
            MongoClient client = new MongoClient(bctDatabaseSettings.Value.ConnectionString);
            IMongoDatabase database = client.GetDatabase(bctDatabaseSettings.Value.DatabaseName);
            _customerCollection = database.GetCollection<Customer>(bctDatabaseSettings.Value.CollectionName);
        }

        //public async Task<List<Customer>> GetAsync() { }
        public async Task CreateAsync(Customer newCustomer) { }
        public async Task AddToPlaylistAsync(string id, string movieId) { }
        public async Task DeleteAsync(string id) { }
    }
}
