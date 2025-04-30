using FribergRealEstatesClient.Services.Base;

namespace FribergRealEstatesClient.Services
{
    public interface IAdvertService
    {
        Task<ICollection<AdvertDto>> GetFilteredAdverts(AdvertFilterDto filterDto);
        Task<ICollection<AdvertDto>> GetFilteredAsync(AdvertFilterDto filter);
    }
}
