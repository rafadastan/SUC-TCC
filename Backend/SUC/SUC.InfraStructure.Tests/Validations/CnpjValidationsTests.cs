using Bogus;
using SUC.Validations;
using Bogus.Extensions.Brazil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace SUC.InfraStructure.Tests.Validations
{
    public class CnpjValidationsTests
    {
        private readonly Faker _faker;

        public CnpjValidationsTests(Faker faker)
        {
            _faker = faker;
        }

        [Fact]
        public void Validar_Cnpj_Valido()
        {
            //Arrange
            var cnpj = "62.848.669/0001-95";
            //Act

            var isValid = CnpjValidation.IsValid(cnpj);

            //Assert
            isValid.Should().BeTrue();
        }
    }
}
