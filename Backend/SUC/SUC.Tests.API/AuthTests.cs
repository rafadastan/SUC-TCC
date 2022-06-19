using FluentAssertions;
using Newtonsoft.Json;
using SUC.Application.Commands.Auth;
using SUC.Tests.API.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SUC.Tests.API
{
    public class AuthTests
    {
        [Fact]
        public async Task<string> Authentication_Post_Returns_Ok()
        {
            //conectar na API..
            var client = HttpClientHelper.Create();

            var command = new AuthenticationCommand
            {
                Cpf = "15278481757",
                Senha = "adminadmin"
            };

            //'empacotando' o objeto para JSON
            var request = RequestHelper.Create(command);

            //fazendo a requisição de autenticação 'POST'
            var response = await client.PostAsync("api/auth", request);

            //capturar o retorno obtido da API
            var result = JsonConvert.DeserializeObject<AuthenticationResult>
                (response.Content.ReadAsStringAsync().Result);

            //criando um criterio de teste (assert)
            response.StatusCode
                .Should() //Fluent Assertions!
                .Be(HttpStatusCode.OK);

            //verificando a mensagem obtida
            result.Mensagem
                .Should() //Fluent Assertions!
                .Be("Autenticado com sucesso");

            //verificando se o token foi obtido
            result.AccessToken
                .Should() //Fluent Assertions!
                .NotBeNullOrEmpty();

            //retornando o TOKEN..
            return result.AccessToken;
        }
    }
}
