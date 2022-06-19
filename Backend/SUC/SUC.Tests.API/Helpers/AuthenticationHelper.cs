using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Tests.API.Helpers
{
    public class AuthenticationHelper
    {
        public static async Task Create(HttpClient client)
        {
            //obtendo o token a partir do teste de autenticação
            var accessToken = await new AuthTests()
                .Authentication_Post_Returns_Ok();

            //adicionar o TOKEN no cabeçalho da requisição
            //que será feita para a API
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", accessToken);
        }
    }
}
