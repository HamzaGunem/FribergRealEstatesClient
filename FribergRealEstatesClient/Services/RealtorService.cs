using FribergRealEstatesClient.Services.Base;

namespace FribergRealEstatesClient.Services
{
    // created by Samuel
    public class RealtorService : BaseHttpService, IRealtorService
    {
        private readonly IClient _client;

        public RealtorService(IClient client) : base(client)
        {
           _client = client;
        }

        public async Task<RealtorProfileDto> GetRealtorProfile(int realtorId)
        {
            var realtor = await _client.ProfileAsync(realtorId);

            return realtor;
        }
    }
}
