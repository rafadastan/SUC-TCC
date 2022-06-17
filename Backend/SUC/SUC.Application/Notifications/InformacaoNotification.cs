using MediatR;
using SUC.Domain.Entities.Informacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Notifications
{
    public class InformacaoNotification : INotification
    {
        public Informacao Informacao { get; set; }
        public ActionNotification Action { get; set; }
    }
}
