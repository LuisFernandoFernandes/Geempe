using Geempe.Application.Result;

namespace Geempe.Application.Interfaces;

public interface IServiceBase<TDto>
{
    Task<ServiceResult<ICollection<TDto>>> GetAll();
    Task<ServiceResult<TDto>> GetById(int id);
    Task<ServiceResult<TDto>> Create(TDto dto);
    Task<ServiceResult<bool>> Update(TDto dto);
    Task<ServiceResult<bool>> Delete(int id);
}
