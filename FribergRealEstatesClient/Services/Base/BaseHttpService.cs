using Blazored.LocalStorage;
using System.Net.Http.Headers;

namespace FribergRealEstatesClient.Services.Base
{
    public class BaseHttpService
    {
        private readonly IClient _client;
        private readonly ILocalStorageService _localStorage;

        public BaseHttpService(IClient client, ILocalStorageService localStorage)
        {
            this._client = client;
            _localStorage = localStorage;
        }

        protected async Task GetBearerToken()
        {
            var token = await _localStorage.GetItemAsync<string>("accessToken");
            if (token != null)
            {
                _client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
            }
        }
    }
}
