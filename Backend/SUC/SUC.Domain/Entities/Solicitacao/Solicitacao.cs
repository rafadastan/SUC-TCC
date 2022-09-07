using SUC.Domain.Enum;
using System;
using SUC.Domain.Entities.Servicos;
using SUC.Domain.Entities.Telefone;
using SUC.Domain.Entities.Avaliacoes;
using static SUC.Domain.Enum.DomainEnum;
using SUC.Domain.Contracts.Base;
using FluentValidation.Results;
using SUC.Domain.Validations;

namespace SUC.Domain.Entities.Solicitacao
{
    public class Solicitacao : IBaseValidations
    {
        public Guid IdSolicitacao { get; set; }
        public string NomeSolicitacao { get; set; }
        public string SobreNomeSolicitacao { get; set; }
        public string EmailSolicitacao { get; set; }
        public string Descricao { get; set; }
        public TipoSolicitacao Status { get; set; }
        public DomainEnum.TipoServico TipoServico { get; set; }
        public int AvaliacaoAtendimento { get; set; }

        public Servico Servico { get; set; }
        public Contato Contato { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public Usuario Usuario { get; set; }

        public ValidationResult Validate 
            => new SolicitacaoValidator().Validate(this);
    }
}
