using Blazored.LocalStorage;
using FribergRealEstatesClient.Services;
using FribergRealEstatesClient.Services.Base;
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

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7053") });

            builder.Services.AddScoped<IClient, Client>();

            builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
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

            await builder.Build().RunAsync();
        }
    }
}
