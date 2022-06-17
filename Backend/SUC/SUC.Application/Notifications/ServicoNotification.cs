using MediatR;
using SUC.Domain.Entities.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Notifications
{
    public class ServicoNotification : INotification
    {
        public Servico Servico { get; set; }
        public ActionNotification Action { get; set; }
    }
}
