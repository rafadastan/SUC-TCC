using FluentValidation;
using FluentValidation.Results;
using SUC.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities.Avaliacoes
{
    public class Avaliacao
    {
        public Guid IdAvaliacao { get; set; }
        public string Descricao { get; set; }
        public int NumeroAvalicao { get; set; }

        //public ValidationResult Validate
        //    => new AvaliacaoValidation().Validate(this);
    }
}
