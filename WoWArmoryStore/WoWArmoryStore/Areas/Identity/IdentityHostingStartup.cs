using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(WoWArmoryStore.Areas.Identity.IdentityHostingStartup))]
namespace WoWArmoryStore.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}