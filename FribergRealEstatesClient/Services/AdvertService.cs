using FribergRealEstatesClient.Models;
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

        public Task<ICollection<AdvertDto>> GetFilteredAsync(AdvertFilterModel filter)
        {
            var dto = new AdvertFilterDto
            {
                ResidenceTypes = filter.ResidenceTypes,
                MinRooms = filter.MinRooms,
                MaxRooms = filter.MaxRooms,
                MinPrice = filter.MinPrice,
                MaxPrice = filter.MaxPrice,
                MinArea = filter.MinArea,
                MaxArea = filter.MaxArea,
                Address = filter.Address
            };

            return _client.FilterAsync(dto);
        }
    }
}
