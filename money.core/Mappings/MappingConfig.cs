using AutoMapper;
using money.core.Features.AccountType.Queries.GetAllAccountTypes;
using money.core.Features.Category.Queries.GetAllCategories;
using money.core.Features.Currency.Queries.GetAllCurrencies;
using money.core.Features.PaymentMode.Queries.GetAllPaymentModes;
using money.core.Features.TransactionType.Queries.GetAllTransactionTypes;
using money.domain.Entities;

namespace money.core.Mappings
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<AccountTypeMaster, AllAccountTypesViewModel>().ReverseMap();
            CreateMap<CategoryMaster, AllCategoryViewModel>().ReverseMap();
            CreateMap<CurrencyMaster, AllCurrencyViewModel>().ReverseMap();
            CreateMap<PaymentModesMaster, AllPaymentModeViewModel>().ReverseMap();
            CreateMap<TransactionTypeMaster, AllTransactionTypesViewModel>().ReverseMap();
        }
    }
}
