using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Graduation.Core
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddPostalCodes(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PostalCodeContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

            return services
                .AddTransient<IPostalCodeProviderService, PostalCodeProviderService>();
        }
    }
}