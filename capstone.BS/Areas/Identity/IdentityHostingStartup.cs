using System;
using capstone.BS.Areas.Identity.Data;
using capstone.BS.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(capstone.BS.Areas.Identity.IdentityHostingStartup))]
namespace capstone.BS.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<capstoneBSContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("capstoneBSContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<capstoneBSContext>();
            });
        }
    }
}