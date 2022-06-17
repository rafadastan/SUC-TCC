using MediatR;
using SUC.Domain.Entities.Indices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Notifications
{
    public class IndiceNotification : INotification
    {
        public Indice Indice { get; set; }
        public ActionNotification Action { get; set; }
    }
}
