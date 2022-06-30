using Bogus;
using Bogus.Extensions.Brazil;
using FluentAssertions;
using SUC.Domain.Contracts.Usuarios;
using SUC.Domain.Entities;
using SUC.Domain.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace SUC.Domain.Tests
{
    public class UsuarioDomainServiceTests
    {
        private readonly IUsuarioDomainService _usuarioDomainService;
        private readonly Faker _faker;

        public UsuarioDomainServiceTests(IUsuarioDomainService usuarioDomainService, 
            Faker faker)
        {
            _usuarioDomainService = usuarioDomainService;
            _faker = faker;
        }

        [Fact]
        public async Task Create_Usuario_Ok()
        {
            //Arrange
            var command = new Usuario
            {
                Nome = _faker.Person.FirstName,
                Sobrenome = _faker.Person.LastName,
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
            var usuario = _usuarioDomainService.Create(command);
            
            //Assert
            usuario.Should()
                .Be(command);
        }
    }
}
