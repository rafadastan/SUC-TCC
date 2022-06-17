using MediatR;
using SUC.Domain.Entities.Chamado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Notifications
{
    public class ChamadoNotification : INotification
    {
        public Chamado Chamado { get; set; }
        public ActionNotification Action { get; set; }
    }
}
