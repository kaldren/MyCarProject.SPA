using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;

namespace Troshka.SPA
{
    public class CustomErrorBoundry : ErrorBoundary
    {
        [Inject]
        private IWebAssemblyHostEnvironment _env { get; set; }

        [Inject]
        private NotificationService _toastService { get; set; }

        protected override Task OnErrorAsync(Exception exception)
        {
            if (_env.IsDevelopment())
                return base.OnErrorAsync(exception);

            return Task.CompletedTask;
        }
    }
}
