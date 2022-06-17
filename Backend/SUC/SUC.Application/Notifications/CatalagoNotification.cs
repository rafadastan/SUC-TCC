using MediatR;
using SUC.Domain.Entities.Catalago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Notifications
{
    public class CatalagoNotification : INotification
    {
        public Catalago Catalago { get; set; }
        public ActionNotification Action { get; set; }
    }
}
