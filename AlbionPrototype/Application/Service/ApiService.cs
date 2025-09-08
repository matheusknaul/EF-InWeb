using Application.Interfaces.Refit;
using Domain.Entities;
using Refit;

namespace Application.Service
{
    public class ApiService
    {
        private readonly IAlbionApi _albionApi;

        public async Task<List<Item>> GetHistoryByItemId(string itemId)
        {
            var api = RestService.For<IAlbionApi>("https://www.albion-online-data.com/api/v2/stats");
            return await api.GetHistoryByItemId(itemId);
        }
    }
}
