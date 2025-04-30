using Blazored.LocalStorage;
using FribergRealEstatesClient.Services.Base;

namespace FribergRealEstatesClient.Services
{
    // created by Samuel
    public class AgencyService : BaseHttpService, IAgencyService
    {
        private readonly IClient _client;

        public AgencyService(IClient client, ILocalStorageService localStorage) : base(client, localStorage)
        {
            _client = client;
        }

        public async Task<AgencyWithSimpleRealtorsDto> GetAgencyProfile(int id) =>
            await _client.WithRealtorsAsync(id);

    }
}
