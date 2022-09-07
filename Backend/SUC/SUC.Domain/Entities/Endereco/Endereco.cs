using FluentValidation.Results;
using SUC.Domain.Contracts.Base;
using SUC.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities.EntityEndereco
{
    public class Endereco : IBaseValidations
    {
        public Guid IdEndereco { get; set; }
        public string EnderecoNome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid? CreatorUserId { get; set; }
        public DateTime? LastModificationDate { get; set; }
        public Guid? LastModifierUserId { get; set; }

        public virtual Usuario Usuario { get; set; }

        public ValidationResult Validate 
            => new EnderecoValidation().Validate(this);
    }
}
