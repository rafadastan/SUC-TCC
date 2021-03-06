using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SUC.Api.Security;
using SUC.Application.Commands.Auth;
using SUC.Application.Contracts.Auth;
using SUC.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUC.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAgendaApplicationService _authApplicationService;
        private readonly AccessTokenService _jwtToken;

        public AuthController(IAgendaApplicationService authApplicationService,
            AccessTokenService jwtToken)
        {
            this._authApplicationService = authApplicationService;
            this._jwtToken = jwtToken;
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> PostAsync(AuthenticationCommand model)
        {
            try
            {
                var athentication = await _authApplicationService.Authentication(model);

                if (athentication != null)
                {
                    return StatusCode(200, new
                    {
                        Message = "Autenticado com sucesso.",
                        Usuario = athentication,
                        AccessToken = new
                        {
                            BearerToken = _jwtToken.GenerateToken(athentication.Email),
                            Expiration = DateTime.Now.AddDays(1)
                        }
                    });
                }

                return Unauthorized();
            }
            catch (Exception e)
            {
                return StatusCode(404, new
                {
                    Message = "Acesso Negado. Usuário não encontrado.",
                    StackTraces = e.StackTrace,
                    MessageError = e.Message
                });
            }
        }
    }
}
