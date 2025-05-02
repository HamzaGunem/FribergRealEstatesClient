using FribergRealEstatesClient.Services.Base;

namespace FribergRealEstatesClient.Services
{
    // created by Samuel
    public interface IRealtorService
    {
        Task<RealtorProfileDto> GetRealtorProfile(int id);

        Task<List<RealtorAdvertsDto>> GetSoldByRealtorAsync(int id);
        Task<RealtorProfileDto> GetMyProfileAsync(); // testkod

        Task<List<RealtorSummaryDto>> GetAllByCity(string cityName);
    }

}
