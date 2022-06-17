using MediatR;
using SUC.Application.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace SUC.Application.Handlers
{
    public class ChamadoHandler : INotificationHandler<ChamadoNotification>
    {
        public Task Handle(ChamadoNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
