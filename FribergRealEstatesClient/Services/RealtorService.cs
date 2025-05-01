using Blazored.LocalStorage;
using FribergRealEstatesClient.Services.Base;
using System.Collections.Generic;

namespace FribergRealEstatesClient.Services
{
    // created by Samuel
    public class RealtorService : BaseHttpService, IRealtorService
    {
        private readonly IClient _client;

        public RealtorService(IClient client, ILocalStorageService localStorage) : base(client, localStorage)
        {
           _client = client;
        }

        public async Task<List<RealtorSummaryDto>> GetAllByCity(string cityName)
        {
            var getRealtors = await _client.ByCommun2Async(cityName);
            return getRealtors.ToList();
        }

        public async Task<RealtorProfileDto> GetRealtorProfile(int realtorId)
        {
            RealtorProfileDto realtor = new();
            try
            {
                var result = await _client.ProfileGETAsync(realtorId);
                realtor = result;
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine($"Fel vid hämtning av mäklarprofil med Id: {realtorId}: {ex.Message}");
            }
            return realtor;
        }

        public async Task<List<RealtorAdvertsDto>> GetSoldByRealtorAsync(int id)
        {
            List<RealtorAdvertsDto> getSoldAdverts = new();

            try
            {
                var result = await _client.SoldAsync(id);
                getSoldAdverts = result.Select(advert =>
                {
                    advert.ImageUrls ??= new List<string>();
                    return advert;
                }).ToList();
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine($"Fel vid hämtning av Annonser för mäklarprofil med Id: {id}: {ex.Message}");
            }
            return getSoldAdverts;
            
        }
    }
}
