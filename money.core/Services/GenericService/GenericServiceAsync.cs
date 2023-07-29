using money.core.Services.Interfaces;
using money.domain.Entities;
using System.Linq.Expressions;

public class GenericServiceAsync<T> : IGenericServiceAsync<T> where T : class
{
    private readonly IGenericServiceAsync<T> _repository;
    public GenericServiceAsync(IGenericServiceAsync<T> repository)
    {
        _repository = repository;
    }

    public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null)
    {
        return await _repository.GetAllAsync(filter);
    }
}