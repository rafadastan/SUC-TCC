using Bogus;
using Bogus.Extensions.Brazil;
using FluentAssertions;
using Newtonsoft.Json;
using SUC.Application.Commands.Usuario;
using SUC.Domain.Models.Usuario;
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
    public class UsuarioTests
    {
        private readonly Faker _faker;

        public UsuarioTests()
        {
            _faker = new Faker("pt_BR");
        }

        [Fact]
        public async Task Usuarios_Post_Returns_Created()
        {
            //Arrange
            var command = new UsuarioCreateCommand
            {
                Nome = _faker.Person.FirstName,
                SobreNome = _faker.Person.LastName,
                Cpf = _faker.Person.Cpf()
                        .Replace(".", string.Empty)
                        .Replace("-", string.Empty),
                Created = _faker.Date.Recent(10),
                LastLogin = _faker.Date.Recent(10),
                Modified = _faker.Date.Recent(10),
                Email = _faker.Person.Email,
                Senha = _faker.Person.Random.Word()
            };

            var client = HttpClientHelper.Create();
            var request = RequestHelper.Create(command);
            await AuthenticationHelper.Create(client);

            //Act
            var response = await client.PostAsync("api/Usuario", request);

            //Assert
            response.StatusCode
                .Should()
                .Be(HttpStatusCode.Created);
        }

        [Fact]
        public async Task Usuarios_Put_Returns_Ok()
        {
            //Arrange
            var usuarios = await Usuarios_GetAll_Returns_Ok();
            var usuario = usuarios.LastOrDefault(x => x.Cpf != "15278481757" && x.Cpf != "15278451513");

            var command = new UsuarioUpdateCommand
            {
                Id = usuario.IdUsuario,
                IdPerfil = usuario.IdPerfil,
                Nome = usuario.Nome,
                SobreNome = _faker.Person.LastName,
                Cpf = usuario.Cpf,
                Created = usuario.Created,
                Email = usuario.Email,
                LastLogin = usuario.LastLogin,
                Modified = usuario.Modified,
                Senha = usuario.Senha
            };

            var client = HttpClientHelper.Create();
            var request = RequestHelper.Create(command);
            await AuthenticationHelper.Create(client);
            
            //Act
            var response = await client.PutAsync("api/Usuario", request);

            //Assert
            response.StatusCode
                .Should()
                .Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Usuarios_Delete_Returns_Ok()
        {
            //Arrange
            var usuarios = await Usuarios_GetAll_Returns_Ok();
            var usuario = usuarios.LastOrDefault(x => x.Cpf != "15278481757" && x.Cpf != "15278451513");

            var client = HttpClientHelper.Create();
            await AuthenticationHelper.Create(client);

            //Act
            var response = await client.DeleteAsync($"api/Usuario/{usuario.IdUsuario}");

            //Assert
            response.StatusCode
                .Should()
                .Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task<List<UsuarioModel>> Usuarios_GetAll_Returns_Ok()
        {
            //Arrange
            var client = HttpClientHelper.Create();
            await AuthenticationHelper.Create(client);

            //Act
            var response = await client.GetAsync("api/Usuario");

            var result = JsonConvert.DeserializeObject<List<UsuarioModel>>
                (response.Content.ReadAsStringAsync().Result);

            //Assert
            response.StatusCode
                .Should()
                .Be(HttpStatusCode.OK);

            result
                .Should()
                .NotBeNullOrEmpty();

            return result;
        }

        [Fact]
        public async Task Usuarios_GetById_Returns_Ok()
        {
            //Arrange
            var usuarios = await Usuarios_GetAll_Returns_Ok();
            var usuario = usuarios.FirstOrDefault();

            var client = HttpClientHelper.Create();
            await AuthenticationHelper.Create(client);

            //Act
            var response = await client.GetAsync($"api/Usuario/{usuario.IdUsuario}");

            var result = JsonConvert.DeserializeObject<UsuarioModel>
                (response.Content.ReadAsStringAsync().Result);

            //Assert
            response.StatusCode
                .Should()
                .Be(HttpStatusCode.OK);

            result.Nome.Should().Be(usuario.Nome);
            result.SobreNome.Should().Be(usuario.SobreNome);
            result.Cpf.Should().Be(usuario.Cpf);
        }
    }
}
