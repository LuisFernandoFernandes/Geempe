using Geempe.Domain.Entities;

namespace Geempe.Infra.Interfaces;

public interface IRepositoryBase<T> where T : EntityBase
{
    Task<ICollection<T>> GetAll();
    Task<T> GetById(int id);
    Task<T> Create(T entity, bool loadNavigationProperties = false);
    Task Update(T entity);
}
