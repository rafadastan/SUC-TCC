using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SUC.Application.Adapters.ValidationErrors;
using SUC.Application.Commands.Perfil;
using SUC.Application.Contracts.Perfil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUC.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilController : ControllerBase
    {
        private readonly IPerfilApplicationService _perfilAppService;

        public PerfilController(IPerfilApplicationService perfilAppService)
        {
            _perfilAppService = perfilAppService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(PerfilCreateCommand), 200)]
        [ProducesResponseType(typeof(BadRequestResult), 400)]
        [ProducesResponseType(typeof(BadHttpRequestException), 500)]
        public async Task<IActionResult> Post(PerfilCreateCommand command)
        {
            try
            {
                await _perfilAppService.Create(command);
                return StatusCode(201, new { Message = "Perfil criado com sucesso." });
            }
            catch (ValidationException e)
            {
                return BadRequest(ValidationErrorAdapter.Parse(e.Errors));
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPut]
        [ProducesResponseType(typeof(PerfilUpdateCommand), 200)]
        [ProducesResponseType(typeof(BadRequestResult), 400)]
        [ProducesResponseType(typeof(BadHttpRequestException), 500)]
        public async Task<IActionResult> Put(PerfilUpdateCommand command)
        {
            try
            {
                await _perfilAppService.Update(command);
                return StatusCode(200, new { Message = "Perfil atualizado com sucesso." });
            }
            catch (ValidationException e)
            {
                return BadRequest(ValidationErrorAdapter.Parse(e.Errors));
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(PerfilDeleteCommand), 200)]
        [ProducesResponseType(typeof(BadRequestResult), 400)]
        [ProducesResponseType(typeof(BadHttpRequestException), 500)]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var command = new PerfilDeleteCommand { Id = id };

                await _perfilAppService.Delete(command);
                return StatusCode(200, new { Message = "Perfil deletado com sucesso." });
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(BadRequestResult), 400)]
        [ProducesResponseType(typeof(BadHttpRequestException), 500)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _perfilAppService.GetAll();

                if (result.Count == 0)
                    return NoContent();

                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("id")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(BadRequestResult), 400)]
        [ProducesResponseType(typeof(BadHttpRequestException), 500)]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var result = await _perfilAppService.GetById(id);

                if (result == null)
                    return NoContent();

                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
