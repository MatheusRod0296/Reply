using Microsoft.Extensions.DependencyInjection;
using Reply.Domain.ReplyContext.Handlers;
using Reply.Domain.ReplyContext.Repository;
using Reply.Infra.ReplyContext.DataContext;
using Reply.Infra.ReplyContext.Repository;

namespace Reply.Api.DependenceInjection
{
    public static class DependencyInjection
    {
        public static void Injection(this IServiceCollection services)
        {
            //Repository
            services.AddScoped<ReplyDataContext, ReplyDataContext>();
            services.AddScoped<IInsuranceRepository, InsuranceRepository>();

            //Handlers
            services.AddScoped<InsuranceHandler, InsuranceHandler>();

          

        }
    }
}
