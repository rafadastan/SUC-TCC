using SUC.Application.Commands.Agenda;
using SUC.Domain.Models.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Contracts.Agenda
{
    public interface IAgendaApplicationService
    {
        Task Create(AgendaCreateCommand command);
        Task Update(AgendaUpdateCommand command);
        Task Delete(AgendaDeleteCommand command);
        Task<List<AgendaModel>> GetAll();
        Task<AgendaModel> GetById(Guid id);
    }
}
