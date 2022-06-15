using MediatR;
using SUC.Domain.Entities.EntityEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Notifications
{
    public class EnderecoNotification : INotification
    {
        public Endereco Endereco { get; set; }
        public ActionNotification Action { get; set; }
    }
}
