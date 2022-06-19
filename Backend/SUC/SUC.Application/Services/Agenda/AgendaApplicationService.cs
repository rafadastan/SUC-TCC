using MediatR;
using SUC.Application.Commands.Agenda;
using SUC.Application.Contracts.Agenda;
using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Services.Agenda
{
    public class AgendaApplicationService : IAgendaApplicationService
    {
        private readonly IMediator _mediator;
        private readonly IAgendaCaching _agendaCaching;

        public AgendaApplicationService(IMediator mediator, 
            IAgendaCaching agendaCaching)
        {
            _mediator = mediator;
            _agendaCaching = agendaCaching;
        }

        public async Task Create(AgendaCreateCommand command)
        {
            await _mediator.Send(command);
        }

        public async Task Update(AgendaUpdateCommand command)
        {
            await _mediator.Send(command);
        }

        public async Task Delete(AgendaDeleteCommand command)
        {
            await _mediator.Send(command);
        }

        public async Task<List<AgendaModel>> GetAll()
        {
            return await _agendaCaching.GetAll();
        }

        public async Task<AgendaModel> GetById(Guid id)
        {
            return await _agendaCaching.GetById(id);
        }
    }
}
