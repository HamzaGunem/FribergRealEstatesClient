using FribergRealEstatesClient.Services.Base;

namespace FribergRealEstatesClient.Services
{
    // created by Samuel
    public interface IRealtorService
    {
        Task<RealtorProfileDto> GetRealtorProfile(int id);

        Task<List<RealtorAdvertsDto>> GetSoldByRealtorAsync(int id);
    }
}
