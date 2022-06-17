using MediatR;
using SUC.Domain.Entities.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Notifications
{
    public class AgendaNotification : INotification
    {
        public Agenda Agenda { get; set; }
        public ActionNotification Action { get; set; }
    }
}
