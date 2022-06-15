using MediatR;
using SUC.Domain.Entities.Telefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Notifications
{
    public class ContatoNotification : INotification
    {
        public Contato Contato { get; set; }
        public ActionNotification Action { get; set; }

    }
}
