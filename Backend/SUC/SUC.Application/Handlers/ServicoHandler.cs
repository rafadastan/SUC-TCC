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
    public class ServicoHandler : INotificationHandler<ServicoNotification>
    {
        public Task Handle(ServicoNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
