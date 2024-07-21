using Geempe.Api.Extensions;
using Geempe.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Geempe.Api.Controllers
{
    public class ControllerBase<TDto>(IServiceBase<TDto> _service) : ControllerBase where TDto : class
    {
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var result = await _service.GetAll();
            return result.IsSuccess ? Ok(result) : BadRequest(result.Error?.Message.ConvertToError());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var result = await _service.GetById(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result.Error?.Message.ConvertToError());
        }

        [HttpPost]
        public async Task<ActionResult> Create(TDto item)
        {
            var result = await _service.Create(item);
            return result.IsSuccess ? Ok(result) : BadRequest(result.Error?.Message.ConvertToError());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(TDto item)
        {
            var result = await _service.Update(item);
            return result.IsSuccess ? Ok(result) : BadRequest(result.Error?.Message.ConvertToError());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _service.Delete(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result.Error?.Message.ConvertToError());
        }
    }
}
