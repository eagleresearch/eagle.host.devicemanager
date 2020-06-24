﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Eagle.Host.DeviceManager
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<DeviceManagerHttpApiHostModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
