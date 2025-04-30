using Blazored.LocalStorage;
using FribergRealEstatesClient.Services.Base;
using System.Collections.Generic;

namespace FribergRealEstatesClient.Services
{
    public class AdvertService : BaseHttpService, IAdvertService
    {
        private readonly IClient _client;

        public AdvertService(IClient client, ILocalStorageService localStorage) : base(client, localStorage)
        {
            _client = client;
        }

        public async Task<ICollection<AdvertDto>> GetFilteredAdverts(AdvertFilterDto filterDto)
        {
            try
            {
                await GetBearerToken();
                return await _client.FilterAsync(filterDto);
            }
            catch (Exception)
            {

                throw;
            }

        }
        /* public async Task<ICollection<AdvertDto>> GetFilteredAdverts(AdvertFilterDto filterDto)
         {
             try
             {
                 return await _client.FilterAsync(filterDto); // token skickas automatiskt
             }
             catch (ApiException ex) when (ex.StatusCode == 401)
             {
                 // hantera 401 bättre här om du vill
                 throw new UnauthorizedAccessException("Ej behörig");
             }
         }*/
    }
}
