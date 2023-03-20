using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using Radzen;
using System.Globalization;
using Troshka.SPA;
using Troshka.SPA.Interfaces;
using TroshkaApi;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddMsalAuthentication(options =>
{
    builder.Configuration.Bind("AzureAdB2C", options.ProviderOptions.Authentication);
    options.ProviderOptions.DefaultAccessTokenScopes.Add(builder.Configuration.GetValue<string>("Api:Scope"));
    options.ProviderOptions.LoginMode = "Redirect";
});

#region Http Clients
builder.Services.AddTransient<CustomAuthorizationMessageHandler>();

builder.Services.AddHttpClient("TroshkaAPIAuth",
        (srv, client) =>
        {
            client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("Api:BaseUrl"));
        })
.AddHttpMessageHandler<CustomAuthorizationMessageHandler>();

builder.Services.AddScoped<ITroshkaApiClient, TroshkaApiClient>((x) =>
{
    var httpClient = x.GetRequiredService<IHttpClientFactory>().CreateClient("TroshkaAPIAuth");
    var client = ActivatorUtilities.CreateInstance<TroshkaApiClient>(x, builder.Configuration.GetValue<string>("Api:BaseUrl"), httpClient);

    return client;
});

builder.Services.AddHttpClient("TroshkaAPINoAuth",
        (srv, client) =>
        {
            client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("Api:BaseUrl"));
        });

builder.Services.AddScoped<ITroshkaApiClientPublic, TroshkaApiClient>((x) =>
{
    var httpClient = x.GetRequiredService<IHttpClientFactory>().CreateClient("TroshkaAPINoAuth");
    var client = ActivatorUtilities.CreateInstance<TroshkaApiClient>(x, builder.Configuration.GetValue<string>("Api:BaseUrl"), httpClient);

    return client;
});
#endregion

#region Radzen
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<DialogService>();
#endregion

#region Localization
builder.Services.AddLocalization();

var jsInterop = builder.Build().Services.GetRequiredService<IJSRuntime>();
var appLanguage = await jsInterop.InvokeAsync<string>("appCulture.get");

if (appLanguage != null)
{
    CultureInfo cultureInfo = new CultureInfo(appLanguage);
    CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
    CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
}
#endregion

#region Other
builder.Services.AddBlazoredLocalStorageAsSingleton();
builder.Services.AddAutoMapper(typeof(Program));
#endregion

await builder.Build().RunAsync();
