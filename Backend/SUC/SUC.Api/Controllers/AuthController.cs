using Microsoft.AspNetCore.Mvc;
using SUC.Application.Commands.Auth;
using SUC.Application.Contracts.Agenda;
using SUC.Security;
using System;
using System.Threading.Tasks;
using SUC.Application.Contracts.Auth;

namespace SUC.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthApplicationService _authApplicationService;
        private readonly AccessTokenService _jwtToken;

        public AuthController(IAuthApplicationService authApplicationService,
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
                var authentication = await _authApplicationService.Authentication(model);

                if (authentication != null)
                {
                    return StatusCode(200, new
                    {
                        Message = "Autenticado com sucesso.",
                        Usuario = authentication,
                        AccessToken = new
                        {
                            BearerToken = _jwtToken.GenerateToken(authentication.Email),
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
