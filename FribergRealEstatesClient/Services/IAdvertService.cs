
using FribergRealEstatesClient.Services.Base;

namespace FribergRealEstatesClient.Services
{
    public interface IAdvertService
    {
        Task<ICollection<AdvertDto>> GetFilteredAsync(AdvertFilterDto filter);
    }
}
