using FribergRealEstatesClient.Services.Base;
using System.Runtime.CompilerServices;

namespace FribergRealEstatesClient.Services
{
    public interface ICommunService
    {
        Task<List<CommunDto>> GetAllCommunsAsync();
    }
}
