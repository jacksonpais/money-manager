using AutoMapper;
using money.core.Features.TransactionType.Queries.GetAllTransactionTypes;
using money.domain.Entities;

namespace money.core.Mappings
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<TransactionTypeMaster, AllTransactionTypesViewModel>().ReverseMap();
        }
    }
}
