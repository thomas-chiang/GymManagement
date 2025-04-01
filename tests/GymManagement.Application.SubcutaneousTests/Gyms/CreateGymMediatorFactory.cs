using GymManagement.Application.Common.Interfaces;
using GymManagement.Application.SubcutaneousTests.Common;
using GymManagement.Application.SubcutaneousTests.Gyms.Commands;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;

namespace GymManagement.Application.SubcutaneousTests.Gyms;

public class CreateGymMediatorFactory: MediatorFactory
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        base.ConfigureWebHost(builder); // Call base configuration

        builder.ConfigureTestServices(services =>
        {
            // Add the specific MockCurrentUserProvider registration for CreateGymTests
            services.AddTransient<ICurrentUserProvider, MockCurrentUserProvider>();
        });
    }
}