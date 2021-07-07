using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Issues;

namespace Application
{
    public static class AddApplicationLayerExtension
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetAssembly(typeof(IIssueViewsRepository)));
        }
    }
}