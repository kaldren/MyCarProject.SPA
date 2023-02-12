using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyCarProject.SPA;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMsalAuthentication(options =>
{
    builder.Configuration.Bind("AzureAdB2C", options.ProviderOptions.Authentication);
    options.ProviderOptions.DefaultAccessTokenScopes.Add(builder.Configuration["Api:Scope"]);
    options.ProviderOptions.LoginMode = "Redirect";
    options.AuthenticationPaths.RemoteProfilePath = "https://onebrb.b2clogin.com/onebrb.onmicrosoft.com/oauth2/v2.0/authorize?p=B2C_1_ProfileEdit&client_id=f79d639f-8196-4deb-b33c-c741e919831c&nonce=defaultNonce&redirect_uri=https%3A%2F%2Flocalhost%3A7130&scope=openid&response_type=id_token&prompt=login";
});

await builder.Build().RunAsync();
