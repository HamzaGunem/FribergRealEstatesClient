using FribergRealEstatesClient.Services.Base;

namespace FribergRealEstatesClient.Services
{
    public class AdvertService : BaseHttpService, IAdvertService
    {
        private readonly IClient _client;

        public AdvertService(IClient client) : base(client)
        {
            _client = client;
        }
    }
}
