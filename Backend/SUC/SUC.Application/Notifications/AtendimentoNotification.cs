using MediatR;
using SUC.Domain.Entities.Atendimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Notifications
{
    public class AtendimentoNotification : INotification
    {
        public Atendimento Atendimento { get; set; }
        public ActionNotification Action { get; set; }
    }
}
