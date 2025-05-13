using Blazored.LocalStorage;
using FribergRealEstatesClient.Providers;
using FribergRealEstatesClient.Services;
using FribergRealEstatesClient.Services.Base;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor;
using MudBlazor.Services;

namespace FribergRealEstatesClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            /*builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7053") });

            builder.Services.AddScoped<IClient, Client>();*/
            builder.Services.AddHttpClient<IClient, Client>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7053"); // din API URL
            });

            builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
            builder.Services.AddScoped<ApiAuthenticationStateProvider>();
            builder.Services.AddScoped<AuthenticationStateProvider>(p => p.GetRequiredService<ApiAuthenticationStateProvider>());
            builder.Services.AddScoped<RealtorStateContainer>();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddBlazoredLocalStorage();

            // MudBlazor
            builder.Services.AddMudServices();
            builder.Services.AddMudServices(config =>
            {
                config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomRight;
                config.SnackbarConfiguration.PreventDuplicates = false;
                config.SnackbarConfiguration.NewestOnTop = false;
                config.SnackbarConfiguration.ShowCloseIcon = true;
                config.SnackbarConfiguration.VisibleStateDuration = 10000;
                config.SnackbarConfiguration.HideTransitionDuration = 500;
                config.SnackbarConfiguration.ShowTransitionDuration = 500;
                config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
            });
                

            // Client Services
            builder.Services.AddScoped<IRealtorService, RealtorService>(); // Samuel
            builder.Services.AddScoped<IAgencyService, AgencyService>(); // Samuel
            builder.Services.AddScoped<IAdvertService, AdvertService>(); // Robert/Oscar
            builder.Services.AddScoped<IResidenceService, ResidenceService>(); // Samuel
            builder.Services.AddScoped<ICommunService, CommunService>(); // Oscar

            await builder.Build().RunAsync();
        }
    }
}
