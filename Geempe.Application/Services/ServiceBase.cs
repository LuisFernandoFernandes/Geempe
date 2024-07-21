using AutoMapper;
using Geempe.Application.Interfaces;
using Geempe.Application.Result;
using Geempe.Domain.Entities;
using Geempe.Infra.Interfaces;

namespace Geempe.Application.Services;

public abstract class ServiceBase<T, TDto>(IRepositoryBase<T> _repository, IMapper _mapper) : IServiceBase<TDto> where T : EntityBase
{
    public async Task<ServiceResult<TDto>> Create(TDto dto)
    {
        try
        {
            var entity = _mapper.Map<T>(dto);
            var createdEntity = await _repository.Create(entity);
            var resultDto = _mapper.Map<TDto>(createdEntity);
            return new ServiceResult<TDto>(resultDto);
        }
        catch (Exception ex)
        {
            return new ServiceResult<TDto>(ex);
        }
    }

    public async Task<ServiceResult<bool>> Delete(int id)
    {
        try
        {
            var entity = await _repository.GetById(id);
            entity.Deactivate();
            await _repository.Update(entity);
            return new ServiceResult<bool>(true);
        }
        catch (Exception ex)
        {
            return new ServiceResult<bool>(ex);
        }
    }

    public async Task<ServiceResult<ICollection<TDto>>> GetAll()
    {
        try
        {
            var entities = await _repository.GetAll();
            var dtos = _mapper.Map<ICollection<TDto>>(entities);
            return new ServiceResult<ICollection<TDto>>(dtos);
        }
        catch (Exception ex)
        {
            return new ServiceResult<ICollection<TDto>>(ex);
        }
    }

    public async Task<ServiceResult<TDto>> GetById(int id)
    {
        try
        {
            var entity = await _repository.GetById(id);
            var dto = _mapper.Map<TDto>(entity);
            return new ServiceResult<TDto>(dto);
        }
        catch (Exception ex)
        {
            return new ServiceResult<TDto>(ex);
        }
    }

    public async Task<ServiceResult<bool>> Update(TDto dto)
    {
        try
        {
            var entity = _mapper.Map<T>(dto);
            await _repository.Update(entity);
            return new ServiceResult<bool>(true);
        }
        catch (Exception ex)
        {
            return new ServiceResult<bool>(ex);
        }
    }
}
