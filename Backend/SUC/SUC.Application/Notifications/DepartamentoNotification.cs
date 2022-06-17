using MediatR;
using SUC.Domain.Entities.DepartamentoEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Notifications
{
    public class DepartamentoNotification : INotification
    {
        public Departamento Departamento { get; set; }
        public ActionNotification Action { get; set; }
    }
}
