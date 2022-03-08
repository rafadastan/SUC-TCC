using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SUC.Api.Security;
using SUC.Application.Commands.Auth;
using SUC.Application.Contracts.Auth;
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
        private readonly IAuthApplicationService _authApplicationService;
        private readonly JwtToken _jwtToken;

        public AuthController(IAuthApplicationService authApplicationService, JwtToken jwtToken)
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
            var athentication = await _authApplicationService.Authentication(model);

            if (athentication != null)
            {
                return StatusCode(200, new
                {
                    Message = "Usuário autenticado com sucesso.",
                    Usuario = athentication,
                    AccessToken = new
                    {
                        BearerToken = _jwtToken.GenerateToken(athentication.Cpf),
                        Expiration = DateTime.Now.AddDays(1)
                    }
                });
            }

            throw new Exception("Acesso Negado. Usuário não encontrado.");                    
        }
    }
}
