using MediatR;
using SUC.Domain.Entities.Demanda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Notifications
{
    public class DemandaNotification : INotification
    {
        public Demanda Demanda { get; set; }
        public ActionNotification Action { get; set; }
    }
}
