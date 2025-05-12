using FribergRealEstatesClient.Services.Base;

namespace FribergRealEstatesClient.Services
{
    // created by Samuel
    public interface IAgencyService
    {
        Task<AgencyWithSimpleRealtorsDto> GetAgencyProfile(int id);

        Task<List<AgencyWithSimpleRealtorsDto>> GetAllAgenciesInCommun(string name);
        Task<IEnumerable<AgencySummaryDto>> GetAllAgenciesAsync();

        //Added by Oscar
        Task<AgencyDto> CreateAgency(AgencyCreateDto agency);
        //Added by Oscar
        Task<List<AgencyEditDto>> GetAllForEdit();
        //Added by Oscar
        Task<AgencyDto> EditAgency(AgencyEditDto agency);
    }
}
