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
            var realtor = await _client.ProfileGETAsync(realtorId);

            return realtor;
        }

        public async Task<List<RealtorAdvertsDto>> GetSoldByRealtorAsync(int id)
        {
            // Ensure all related data (e.g., ImageUrls) is fetched in one call
            var getSoldAdverts = await _client.SoldAsync(id);
            return getSoldAdverts.Select(advert =>
            {
                advert.ImageUrls = advert.ImageUrls ?? new List<string>(); // Ensure non-null
                return advert;
            }).ToList();
        }
    }
}
