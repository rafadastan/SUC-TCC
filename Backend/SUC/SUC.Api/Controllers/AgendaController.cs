using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SUC.Application.Adapters.ValidationErrors;
using SUC.Application.Commands.Agenda;
using SUC.Application.Contracts.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUC.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaController : ControllerBase
    {
        private readonly IAgendaApplicationService _agendaApplicationService;

        public AgendaController(IAgendaApplicationService agendaApplicationService)
        {
            _agendaApplicationService = agendaApplicationService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(AgendaCreateCommand), 200)]
        [ProducesResponseType(typeof(BadRequestResult), 400)]
        [ProducesResponseType(typeof(BadHttpRequestException), 500)]
        public async Task<IActionResult> Post(AgendaCreateCommand command)
        {
            try
            {
                await _agendaApplicationService.Create(command);
                return StatusCode(201, new
                {
                    Message = "Agenda criado com sucesso",
                    Usuario = command
                });
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
        [ProducesResponseType(typeof(AgendaUpdateCommand), 200)]
        [ProducesResponseType(typeof(BadRequestResult), 400)]
        [ProducesResponseType(typeof(BadHttpRequestException), 500)]
        public async Task<IActionResult> Update(AgendaUpdateCommand command)
        {
            try
            {
                await _agendaApplicationService.Update(command);
                return StatusCode(201, new
                {
                    Message = "Agenda atualizado com sucesso",
                    Usuario = command
                });
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
        [ProducesResponseType(typeof(AgendaDeleteCommand), 200)]
        [ProducesResponseType(typeof(BadRequestResult), 400)]
        [ProducesResponseType(typeof(BadHttpRequestException), 500)]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var command = new AgendaDeleteCommand { IdAgenda = id };

                await _agendaApplicationService.Delete(command);
                return StatusCode(200, new { Message = "Agenda deletado com sucesso." });
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
                var result = await _agendaApplicationService.GetAll();

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
                var result = await _agendaApplicationService.GetById(id);

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
