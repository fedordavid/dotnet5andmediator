using API.Behaviors;
using API.Validators;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace API
{
    public static class AddApiLayerExtension
    {
        public static IMvcBuilder AddApiLayer(this IServiceCollection services)
        {
            services.AddMvc().AddFluentValidation(cfg => cfg.RegisterValidatorsFromAssemblyContaining(typeof(IssueValidator)));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            return services.AddControllers();
        }
    }
}