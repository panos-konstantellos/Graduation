using System;

using Graduation.Web.Data;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Graduation.Core
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddPostalCodes(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PostalCodeContext>(options =>  options.UseDatabase(configuration));

            return services
                .AddTransient<IPostalCodeProviderService, PostalCodeProviderService>();
        }

        public static IServiceCollection AddEducation(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EducationContext>(options =>  options.UseDatabase(configuration));

            return services;
        }

        public static IServiceCollection AddIdentity(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDbContext<IdentityContext>(options => options.UseDatabase(configuration));

            services
                .AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<IdentityContext>();

            return services;
        }

        public static DbContextOptionsBuilder UseDatabase(this DbContextOptionsBuilder options, IConfiguration configuration)
        {
            var databaseProvider =
                Enum.TryParse(typeof(DatabaseProvider), configuration["DatabaseProvider"], true, out var _databaseProvider)
                    ? (DatabaseProvider) _databaseProvider
                    : throw new Exception($"Unsupported provider {configuration["DatabaseProvider"]}");

            return _ = databaseProvider switch
            {
                DatabaseProvider.Sqlite => options.UseSqlite(configuration.GetConnectionString("DefaultConnection"),
                    x => x.MigrationsAssembly("Graduation.Core.Sqlite")),
                DatabaseProvider.MariaDB => options.UseMySql(configuration.GetConnectionString("MariaDBConnection"),
                    MariaDbServerVersion.LatestSupportedServerVersion
                    , x => x.MigrationsAssembly("Graduation.Core.MariaDB")),
                _ => throw new Exception("Unsupported provider")
            };
        }
    }
}