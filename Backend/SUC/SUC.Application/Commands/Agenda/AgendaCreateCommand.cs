using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Commands.Agenda
{
    public class AgendaCreateCommand : IRequest
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
        public DateTime DataAgenda { get; set; }
    }
}
