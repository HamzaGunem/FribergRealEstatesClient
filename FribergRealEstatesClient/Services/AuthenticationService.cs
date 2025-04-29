using Blazored.LocalStorage;
using FribergRealEstatesClient.Services.Base;


namespace FribergRealEstatesClient.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IClient _client;
        private readonly ILocalStorageService _localStorageService;

        public AuthenticationService(IClient client, ILocalStorageService localStorageService)
        {
            _client = client;
            _localStorageService = localStorageService;
        }

        public async Task<bool> AuthenticateAsync(LoginUserDto loginUserDto)
        {
            var response = await _client.LoginAsync(loginUserDto);
            _localStorageService.SetItemAsync("accessToken", response.Token);
            return true;
        }

        public Task Logout()
        {
            throw new NotImplementedException();
        }
    }
}
