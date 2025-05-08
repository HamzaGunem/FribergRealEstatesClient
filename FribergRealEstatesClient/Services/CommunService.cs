using Blazored.LocalStorage;
using FribergRealEstatesClient.Services.Base;

namespace FribergRealEstatesClient.Services
{
    public class CommunService : BaseHttpService ,ICommunService
    {
        private readonly IClient client;

        public CommunService(IClient client, ILocalStorageService localStorage) : base(client, localStorage)
        {
            this.client = client;
        }

        public async Task<List<CommmunDto>> GetAllCommunsAsync()
        {
           return client.C
        }
    }
}
