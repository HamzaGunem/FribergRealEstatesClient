using FribergRealEstatesClient.Services.Base;

namespace FribergRealEstatesClient.Services
{
    // created by Samuel
    public interface IRealtorService
    {
        Task<RealtorProfileDto> GetRealtorProfile(int id);

        Task<List<RealtorAdvertsDto>> GetSoldByRealtorAsync(int id);
        Task<RealtorFullProfileDto> GetMyProfileAsync(); // testkod

        Task<List<RealtorSummaryDto>> GetAllByCity(string cityName);
        Task<IEnumerable<AdminRealtorUserDto>> GetAllRealtors(); // Robert
        Task UpdateRealtorUserAsync(AdminRealtorUserDto realtorUserDto); // Robert
    }

}
