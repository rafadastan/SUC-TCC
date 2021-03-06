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
            var response = await client.PostAsync("api/Auth", request);

            //capturar o retorno obtido da API
            var result = JsonConvert.DeserializeObject<AuthenticationResult>
                (response.Content.ReadAsStringAsync().Result);

            //criando um criterio de teste (assert)
            response.StatusCode
                .Should() //Fluent Assertions!
                .Be(HttpStatusCode.OK);

            //verificando a mensagem obtida
            result.Message
                .Should() //Fluent Assertions!
                .Be("Autenticado com sucesso.");

            //verificando se o token foi obtido
            result.AccessToken
                .BearerToken
                .Should() //Fluent Assertions!
                .NotBeNullOrEmpty();

            //retornando o TOKEN..
            return result
                .AccessToken
                .BearerToken;
        }

        [Fact]
        public async Task Authentication_Post_Returns_Unauthorized()
        {
            //conectar na API..
            var client = HttpClientHelper.Create();

            //criando o objeto da requisição
            var command = new AuthenticationCommand
            {
                Cpf = "teste@gmail.com",
                Senha = "teste123456"
            };

            //'empacotando' o objeto para JSON
            var request = RequestHelper.Create(command);

            //fazendo a requisição de autenticação 'POST'
            var response = await client.PostAsync("api/auth", request);

            //criando um criterio de teste (assert)
            response.StatusCode
                .Should() //Fluent Assertions!
                .Be(HttpStatusCode.Unauthorized);
        }
    }
}
