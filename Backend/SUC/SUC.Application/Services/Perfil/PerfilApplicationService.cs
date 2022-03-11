using MediatR;
using SUC.Application.Commands.Perfil;
using SUC.Application.Contracts.Perfil;
using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Perfil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Services.Perfil
{
    public class PerfilApplicationService : IPerfilApplicationService
    {
        private readonly IMediator _mediator;
        private readonly IPerfilCaching _perfilCaching;

        public PerfilApplicationService(IMediator mediator,
            IPerfilCaching perfilCaching)
        {
            _mediator = mediator;
            _perfilCaching = perfilCaching;
        }

        public async Task Create(PerfilCreateCommand command)
        {
            await _mediator.Send(command);
        }

        public async Task Update(PerfilUpdateCommand command)
        {
            await _mediator.Send(command);
        }

        public async Task Delete(PerfilDeleteCommand command)
        {
            await _mediator.Send(command);
        }

        public async Task<List<PerfilModel>> GetAll()
        {
            return await _perfilCaching.GetAll();
        }

        public async Task<PerfilModel> GetById(Guid id)
        {
            return await _perfilCaching.GetById(id);
        }
    }
}
