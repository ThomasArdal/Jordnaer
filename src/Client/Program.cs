using Blazored.LocalStorage;
using Jordnaer.Client;
using Jordnaer.Client.Authentication;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient<AuthClient>(client =>
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

builder.Services.AddHttpClient<UserClient>(client =>
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

builder.Services.AddMudServices(configuration => configuration.SnackbarConfiguration = new SnackbarConfiguration
{
    VisibleStateDuration = 2500,
    ShowTransitionDuration = 250,
    BackgroundBlurred = true,
    MaximumOpacity = 90,
    MaxDisplayedSnackbars = 3,
    PositionClass = Defaults.Classes.Position.TopRight,
    HideTransitionDuration = 100,
    ShowCloseIcon = false
});

builder.Services.AddWasmAuthentication();

builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
