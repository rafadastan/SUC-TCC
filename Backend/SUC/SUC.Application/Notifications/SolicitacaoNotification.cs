using MediatR;
using SUC.Domain.Entities.Solicitacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Notifications
{
    public class SolicitacaoNotification : INotification
    {
        public Solicitacao Solicitacao { get; set; }
        public ActionNotification Action { get; set; }
    }
}
