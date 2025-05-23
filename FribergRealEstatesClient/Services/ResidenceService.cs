﻿using Blazored.LocalStorage;
using FribergRealEstatesClient.Services.Base;

namespace FribergRealEstatesClient.Services
{
    // made by Samuel
    public class ResidenceService : BaseHttpService, IResidenceService
    {
        private readonly IClient _client;

        public ResidenceService(IClient client, ILocalStorageService localStorage) : base(client, localStorage)
        {
            _client = client;
        }

        // by Samuel
        // kräver SuperAdmin role
        public async Task CreateResidence(CreateResidenceDto dto)
        {
            await GetBearerToken();
            await _client.ResidencePOSTAsync(dto);
        }
    }
}
