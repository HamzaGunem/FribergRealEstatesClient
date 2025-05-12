using Blazored.LocalStorage;
using FribergRealEstatesClient.Services.Base;
using static System.Net.WebRequestMethods;

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


        public async Task<List<AgencyWithSimpleRealtorsDto>> GetAllAgenciesInCommun(string name)
        {
            var agencies = await _client.ByCommunAsync(name);
            return agencies.ToList();
        }

        public async Task<IEnumerable<AgencySummaryDto>> GetAllAgenciesAsync()
        {
            var agencies = await _client.AllAsync();
            return agencies;
        }
        //Added by Oscar
        public async Task<AgencyDto> CreateAgency(AgencyCreateDto agency)
        {
           return await _client.CreatePOST2Async(agency);
            
        }
        public async Task<List<AgencyEditDto>> GetAllForEdit()
        {
            var agencies = await _client.All2Async();
            return agencies.ToList();

        }
        public async Task<AgencyDto> EditAgency(AgencyEditDto agency)
        {
            return await _client.AgencyAsync(agency.Id, agency);
        }
    }
}
