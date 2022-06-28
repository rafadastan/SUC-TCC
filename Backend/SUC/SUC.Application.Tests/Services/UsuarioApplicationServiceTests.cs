using Bogus;
using Bogus.Extensions.Brazil;
using FluentAssertions;
using SUC.Application.Commands.Usuario;
using SUC.Application.Contracts.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SUC.Application.Tests.Services
{
    public class UsuarioApplicationServiceTests
    {
        private readonly IUsuarioApplicationService _usuarioApplicationService;
        private readonly Faker _faker;

        public UsuarioApplicationServiceTests(IUsuarioApplicationService usuarioApplicationService, 
            Faker faker)
        {
            _usuarioApplicationService = usuarioApplicationService;
            _faker = faker;
        }

        [Fact]
        public async Task Create_Usuario_Ok()
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

            //Act
            await _usuarioApplicationService.Create(command);

            Notifications
                .ActionNotification
                .Create
                .Should()
                .Be(command);
        }
    }
}
