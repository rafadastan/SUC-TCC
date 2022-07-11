using FluentValidation.Results;
using SUC.Domain.Contracts.Base;
using SUC.Domain.Enum;
using SUC.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities
{
    public class Perfil : IBaseValidations
    {
        public Guid IdPerfil { get; set; }
        public PerfilEnum PerfilUsuario { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public ValidationResult Validate
            => new PerfilValidation()
            .Validate(this);
    }
}
