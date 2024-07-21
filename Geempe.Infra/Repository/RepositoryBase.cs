using Geempe.Domain.Entities;
using Geempe.Infra.Context;
using Geempe.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Geempe.Infra.Repository;

public abstract class RepositoryBase<T>(AppDBContext _context) : IRepositoryBase<T> where T : EntityBase
{
    public async Task<T> Create(T entity, bool loadNavigationProperties = false)
    {
        _context.Set<T>().Add(entity);
        await _context.SaveChangesAsync();
        if (loadNavigationProperties)
        {
            var navigationProperties = _context.Entry(entity).Navigations;
            foreach (var navigationProperty in navigationProperties)
            {
                await navigationProperty.LoadAsync();
            }
        }
        return entity;
    }

    public async Task<ICollection<T>> GetAll()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetById(int id)
    {
        return await _context.Set<T>().FindAsync(id) ?? throw new Exception("Item não encontrado.");
    }

    public Task Update(T entity)
    {
        _context.Set<T>().Update(entity);
        return _context.SaveChangesAsync();
    }
}
