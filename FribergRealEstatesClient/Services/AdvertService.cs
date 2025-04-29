
using FribergRealEstatesClient.Services.Base;

namespace FribergRealEstatesClient.Services
{
    public class AdvertService : BaseHttpService, IAdvertService
    {
        private readonly IClient _client;

        public AdvertService(IClient client) : base(client)
        {
            this._client = client;
        }

        public async Task<ICollection<AdvertDto>> GetFilteredAsync(AdvertFilterDto filter)
        {
            
            var result = await _client.FilterAsync(filter);
            return result.ToList();
        }
    }
}
