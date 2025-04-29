using Blazored.LocalStorage;
using FribergRealEstatesClient.Providers;
using FribergRealEstatesClient.Services.Base;
using Microsoft.AspNetCore.Components.Authorization;



namespace FribergRealEstatesClient.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IClient _client;
        private readonly ILocalStorageService _localStorageService;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public AuthenticationService(IClient client, ILocalStorageService localStorageService, AuthenticationStateProvider authenticationStateProvider)
        {
            _client = client;
            _localStorageService = localStorageService;
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<bool> AuthenticateAsync(LoginUserDto loginUserDto)
        {
            var response = await _client.LoginAsync(loginUserDto);
            await _localStorageService.SetItemAsync("accessToken", response.Token);
            await ((ApiAuthenticationStateProvider)_authenticationStateProvider).LoggedIn();
            return true;
        }

        public Task Logout()
        {
            throw new NotImplementedException();
        }
    }
}
