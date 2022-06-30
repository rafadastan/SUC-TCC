using Bogus;
using Bogus.Extensions.Brazil;
using FluentAssertions;
using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Usuario;
using System;
using Xunit;

namespace SUC.InfraStructure.Tests
{
    public class UsuarioCachingTests
    {
        private readonly IUsuarioCaching _usuarioCaching;
        private readonly Faker _faker;

        public UsuarioCachingTests(IUsuarioCaching usuarioCaching, 
            Faker faker)
        {
            _usuarioCaching = usuarioCaching;
            _faker = faker;
        }

        [Fact]
        public void Usuario_Create_Ok()
        {
            //Arrange
            var command = new UsuarioModel
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
            var usuarioCaching = _usuarioCaching.Create(command);

            //Assert
            usuarioCaching.Should()
                .Be(command);
        }
    }
}
