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
    public class OrgaoHandler : INotificationHandler<OrgaoNotification>
    {
        public Task Handle(OrgaoNotification notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }    }
}
