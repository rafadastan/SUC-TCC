using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SUC.Application.Adapters.ValidationErrors;
using SUC.Application.Commands.Usuario;
using SUC.Application.Contracts.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUC.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioApplicationService _usuarioAppService;

        public UsuarioController(IUsuarioApplicationService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(UsuarioCreateCommand),200)]
        [ProducesResponseType(typeof(BadRequestResult),400)]
        [ProducesResponseType(typeof(BadHttpRequestException),500)]
        public async Task<IActionResult> Post(UsuarioCreateCommand command)
        {
            try
            {
                await _usuarioAppService.Create(command);
                return StatusCode(201, new { Message = "Usuario criado com sucesso" });
            }
            catch (ValidationException e)
            {
                return BadRequest(ValidationErrorAdapter.Parse(e.Errors));
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPut]
        [ProducesResponseType(typeof(UsuarioUpdateCommand), 200)]
        [ProducesResponseType(typeof(BadRequestResult), 400)]
        [ProducesResponseType(typeof(BadHttpRequestException), 500)]
        public async Task<IActionResult> Put(UsuarioUpdateCommand command)
        {
            try
            {
                await _usuarioAppService.Update(command);
                return StatusCode(200, new { Message = "Usuario atualizado com sucesso." });
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
        [ProducesResponseType(typeof(UsuarioDeleteCommand), 200)]
        [ProducesResponseType(typeof(BadRequestResult), 400)]
        [ProducesResponseType(typeof(BadHttpRequestException), 500)]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var command = new UsuarioDeleteCommand { Id = id };

                await _usuarioAppService.Delete(command);
                return StatusCode(200, new { Message = "Usuario deletado com sucesso." });
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
                var result = await _usuarioAppService.GetAll();

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
                var result = await _usuarioAppService.GetById(id);

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
