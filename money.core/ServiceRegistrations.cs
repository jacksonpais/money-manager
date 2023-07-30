using Microsoft.Extensions.DependencyInjection;
using money.core.Services.AccountTypeServices;
using money.core.Services.CategoryServices;
using money.core.Services.CurrencyServices;
using money.core.Services.Interfaces;
using money.core.Services.PaymentModeServices;
using money.core.Services.TransactionTypeServices;
using money.infrastructure.Repositories.AccountTypeRepository;
using money.infrastructure.Repositories.CategoryRepositoryAsync;
using money.infrastructure.Repositories.CurrencyRepositoryAsync;
using money.infrastructure.Repositories.GenericRepository;
using money.infrastructure.Repositories.Interfaces;
using money.infrastructure.Repositories.PaymentModeRepositoryAsync;
using money.infrastructure.Repositories.TransactionTypeRepository;

namespace money.core
{
    public static class ServiceRegistrations
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            //Service
            services.AddTransient(typeof(IGenericServiceAsync<>), typeof(GenericServiceAsync<>));
            services.AddTransient<IAccountTypeServiceAsync, AccountTypeServiceAsync>();
            services.AddTransient<ICategoryServiceAsync, CategoryServiceAsync>();
            services.AddTransient<ICurrencyServiceAsync, CurrencyServiceAsync>();
            services.AddTransient<IPaymentModeServiceAsync, PaymentModeServiceAsync>();
            services.AddTransient<ITransactionTypeServiceAsync, TransactionTypeServiceAsync>();

            //Repository
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            services.AddTransient<IAccountTypeRepositoryAsync, AccountTypeRepositoryAsync>();
            services.AddTransient<ICategoryRepositoryAsync, CategoryRepositoryAsync>();
            services.AddTransient<ICurrencyRepositoryAsync, CurrencyRepositoryAsync>();
            services.AddTransient<IPaymentModeRepositoryAsync, PaymentModeRepositoryAsync>();
            services.AddTransient<ITransactionTypeRepositoryAsync, TransactionTypeRepositoryAsync>();
            return services;
        }
    }
}
