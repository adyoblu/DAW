using System;
using DAW.Domain.EF;
using DAW.WebApi;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DAW.WebApi.Areas.Identity.IdentityHostingStartup))]
namespace DAW.WebApi.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Storage>(options =>
                    options.UseSqlServer(
                       context.Configuration.GetConnectionString("DefaultString")));
            });
        }
    }
}