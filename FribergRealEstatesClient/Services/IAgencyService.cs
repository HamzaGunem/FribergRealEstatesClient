using FribergRealEstatesClient.Services.Base;

namespace FribergRealEstatesClient.Services
{
    // created by Samuel upd
    public interface IAgencyService
    {
        Task<AgencyWithSimpleRealtorsDto> GetAgencyProfile(int id);
    }
}
