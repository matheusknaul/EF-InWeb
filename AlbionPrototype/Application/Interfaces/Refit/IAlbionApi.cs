using Domain.Entities;
using Refit;

namespace Application.Interfaces.Refit
{
    public interface IAlbionApi
    {
        [Get("/prices/{itemId}")]
        Task<List<Item>> GetHistoryByItemId(string itemId);
    }
}
