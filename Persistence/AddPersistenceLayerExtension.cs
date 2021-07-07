using Application.Commands;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Issues;
using Persistence.Profiles;

namespace Persistence
{
    public static class AddPersistenceLayerExtension
    {
        public static void AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(IssueViewProfile));
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(configuration.GetConnectionString("Database")));
            services.AddScoped<IIssueViewsRepository, IssueQueryRepository>();
            services.AddScoped<IIssuesRepository, IssueCommandRepository>();
        }
    }
}