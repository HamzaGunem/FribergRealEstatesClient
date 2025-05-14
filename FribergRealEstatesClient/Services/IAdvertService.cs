using FribergRealEstatesClient.Services.Base;

namespace FribergRealEstatesClient.Services
{
    public interface IAdvertService
    {
        Task<ICollection<AdvertDto>> GetFilteredAdverts(AdvertFilterDto filterDto);
        Task<ICollection<AdvertDto>> GetFilteredAsync(AdvertFilterDto filter);
        Task CreateAdvert(AdvertCreateDto dto);
        Task<List<AdvertDto>> AllActiveAdvertsAsync();
        Task<AdvertUpdateDto> UpdateAdvert(int advert, AdvertUpdateDto advertDto);
    }
}
