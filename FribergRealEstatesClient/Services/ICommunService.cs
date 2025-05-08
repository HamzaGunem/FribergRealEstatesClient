using System.Runtime.CompilerServices;

namespace FribergRealEstatesClient.Services
{
    public interface ICommunService
    {
        Task<List<CommmunDto>> GetAllCommunsAsync();
    }
}
