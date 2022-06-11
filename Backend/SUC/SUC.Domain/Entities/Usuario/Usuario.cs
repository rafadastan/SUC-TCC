using FluentValidation.Results;
using SUC.Domain.Validations;
using System;
using System.Collections.Generic;
using SUC.Domain.Entities.Telefone;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities
{
    public class Usuario
    {
        public Guid IdUsuario { get; set; }
        public Guid IdContato { get; set; }
        public Guid IdPerfil { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public DateTime LastLogin { get; set; }
        public Contato Contato { get; set; }
        public Perfil Perfil { get; set; }
        public ValidationResult Validate 
            => new UsuarioValidation().Validate(this);
    }
}
