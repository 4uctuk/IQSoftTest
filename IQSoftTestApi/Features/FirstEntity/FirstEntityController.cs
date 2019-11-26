using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using IQSoftTestApi.Features.DataContext.Model;
using IQSoftTestApi.Features.EntityService;
using Microsoft.AspNetCore.Mvc;

namespace IQSoftTestApi.Features.FirstEntity
{
    [ApiController]
    [Route("first")]
    public class FirstEntityController : ControllerBase
    {
        private readonly IFirstEntityService _entityService;

        public FirstEntityController(IFirstEntityService entityService)
        {
            _entityService = entityService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<FirstTestEntity>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var items = await _entityService.GetAllEntities();
                return Ok(items);
            }
            catch (Exception e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _entityService.DeleteEntity(id);
                return Ok();
            }
            catch (EntityNotFoundException<FirstTestEntity> e)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, e.Message);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Update(int id, UpdateFirstEntityDto dto)
        {
            try
            {
                var item = await _entityService.Get(id);
                item.ItemId = dto.ItemId ?? item.ItemId;
                item.Col2Item = string.IsNullOrEmpty(dto.Col2Item) ? item.Col2Item : dto.Col2Item;
                item.Col3Item = string.IsNullOrEmpty(dto.Col3Item) ? item.Col3Item : dto.Col3Item;
                item.Col4Item = string.IsNullOrEmpty(dto.Col4Item) ? item.Col4Item : dto.Col4Item;
                item.Col5Item = string.IsNullOrEmpty(dto.Col5Item) ? item.Col5Item : dto.Col5Item;

                item.Col6Item = string.IsNullOrEmpty(dto.Col6Item) ? item.Col6Item : dto.Col6Item;
                item.Col7Item = string.IsNullOrEmpty(dto.Col7Item) ? item.Col7Item : dto.Col7Item;
                item.Col8Item = string.IsNullOrEmpty(dto.Col8Item) ? item.Col8Item : dto.Col8Item;
                item.Col9Item = string.IsNullOrEmpty(dto.Col9Item) ? item.Col9Item : dto.Col9Item;
                item.Col10Item = string.IsNullOrEmpty(dto.Col10Item) ? item.Col10Item : dto.Col10Item;

                item.Col11Item = string.IsNullOrEmpty(dto.Col11Item) ? item.Col11Item : dto.Col11Item;
                item.Col12Item = string.IsNullOrEmpty(dto.Col12Item) ? item.Col12Item : dto.Col12Item;
                item.Col13Item = string.IsNullOrEmpty(dto.Col13Item) ? item.Col13Item : dto.Col13Item;
                item.Col14Item = string.IsNullOrEmpty(dto.Col14Item) ? item.Col14Item : dto.Col14Item;
                item.Col15Item = string.IsNullOrEmpty(dto.Col15Item) ? item.Col15Item : dto.Col15Item;

                item.Col16Item = string.IsNullOrEmpty(dto.Col16Item) ? item.Col16Item : dto.Col16Item;
                item.Col17Item = string.IsNullOrEmpty(dto.Col17Item) ? item.Col17Item : dto.Col17Item;
                item.Col18Item = string.IsNullOrEmpty(dto.Col18Item) ? item.Col18Item : dto.Col18Item;
                item.Col19Item = string.IsNullOrEmpty(dto.Col19Item) ? item.Col19Item : dto.Col19Item;
                item.Col20Item = string.IsNullOrEmpty(dto.Col20Item) ? item.Col20Item : dto.Col20Item;
                

                await _entityService.UpdateEntity(item);

                return Ok();
            }
            catch (EntityNotFoundException<FirstTestEntity> e)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, e.Message);
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
