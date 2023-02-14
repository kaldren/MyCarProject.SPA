using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace MyCarProject.SPA
{
    public class CustomAuthorizationMessageHandler : AuthorizationMessageHandler
    {
        private readonly IConfiguration _configuration;

        public CustomAuthorizationMessageHandler(IAccessTokenProvider provider,
            NavigationManager navigationManager, IConfiguration configuration)
            : base(provider, navigationManager)
        {
            _configuration = configuration;
            ConfigureHandler(new[] { _configuration.GetValue<string>("Api:FullUrl") });
        }
    }
}
