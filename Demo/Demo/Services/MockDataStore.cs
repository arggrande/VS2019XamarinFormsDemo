using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Models;
using Newtonsoft.Json;

namespace Demo.Services
{
    public class MockDataStore : IDataStore<Movie>
    {
        List<Movie> _itemStore;

        public MockDataStore()
        {
            _itemStore = JsonConvert.DeserializeObject<List<Movie>>(EmbeddedResource.Get("Dataset.movies.json"));
        }

        public async Task<bool> AddItemAsync(Movie item)
        {
            _itemStore.Add(item);
            
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Movie item)
        {
            var oldItem = _itemStore.Where((Movie arg) => arg.Id == item.Id).FirstOrDefault();
            _itemStore.Remove(oldItem);
            _itemStore.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = _itemStore.Where((Movie arg) => arg.Id.ToString() == id).FirstOrDefault();
            _itemStore.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Movie> GetItemAsync(string id)
        {
            return await Task.FromResult(_itemStore.FirstOrDefault(s => s.Id.ToString() == id));
        }

        public async Task<IEnumerable<Movie>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(_itemStore);
        }
    }
}