using FribergRealEstatesClient.Services.Base;

namespace FribergRealEstatesClient.Services
{
    // made by Samuel
    public interface IResidenceService
    {
        Task CreateResidence(CreateResidenceDto dto);
    }
}
