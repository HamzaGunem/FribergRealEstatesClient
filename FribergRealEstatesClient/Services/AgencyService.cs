using FribergRealEstatesClient.Services.Base;

namespace FribergRealEstatesClient.Services
{
    // created by Samuel upd
    public class AgencyService : BaseHttpService, IAgencyService
    {
        private readonly IClient _client;

        public AgencyService(IClient client) : base(client)
        {
            _client = client;
        }

        public async Task<AgencyWithSimpleRealtorsDto> GetAgencyProfile(int id) =>
            await _client.WithRealtorsAsync(id);

    }
}
