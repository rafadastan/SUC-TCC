using FluentValidation.Results;
using SUC.Domain.Validations;
using System;
using SUC.Domain.Entities.Telefone;
using SUC.Domain.Entities.EntityEndereco;
using SUC.Domain.Contracts.Base;

namespace SUC.Domain.Entities
{
    public class Usuario : IBaseValidations
    {
        public Guid IdUsuario { get; set; }
        public Guid IdPerfil { get; set; }
        public Guid? IdEndereco { get; set; }
        public Guid? IdContato { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? LastLogin { get; set; }

        public virtual Contato Contato { get; set; }
        public virtual Perfil Perfil { get; set; }
        public virtual Endereco Endereco { get; set; }

        public ValidationResult Validate 
            => new UsuarioValidation().Validate(this);
    }
}
