using FribergRealEstatesClient.Services.Base;

namespace FribergRealEstatesClient.Services
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(LoginUserDto loginUserDto);

        Task Logout();
    }
}
