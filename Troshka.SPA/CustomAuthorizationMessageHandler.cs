using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace Troshka.SPA
{
    public class CustomAuthorizationMessageHandler : AuthorizationMessageHandler
    {
        public CustomAuthorizationMessageHandler(IAccessTokenProvider provider,
            NavigationManager navigationManager, IConfiguration configuration)
            : base(provider, navigationManager)
        {
            ConfigureHandler(new[] { configuration.GetValue<string>("Api:FullUrl") });
        }
    }
}
