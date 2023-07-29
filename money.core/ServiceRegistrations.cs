using Microsoft.Extensions.DependencyInjection;
using money.core.Services.Interfaces;
using money.core.Services.TransactionTypeServices;
using money.infrastructure.Repositories.GenericRepository;
using money.infrastructure.Repositories.Interfaces;
using money.infrastructure.Repositories.TransactionTypeRepository;

namespace money.core
{
    public static class ServiceRegistrations
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            //Service
            services.AddTransient(typeof(IGenericServiceAsync<>), typeof(GenericServiceAsync<>));
            services.AddTransient<ITransactionTypeServiceAsync, TransactionTypeServiceAsync>();

            //Repository
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            services.AddTransient<ITransactionTypeRepositoryAsync, TransactionTypeRepositoryAsync>();
            return services;
        }
    }
}
