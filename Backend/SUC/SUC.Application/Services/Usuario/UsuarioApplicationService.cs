using MediatR;
using SUC.Application.Commands.Usuario;
using SUC.Application.Contracts.Usuario;
using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Application.Services.Usuario
{
    public class UsuarioApplicationService : IUsuarioApplicationService
    {
        private readonly IMediator _mediator;
        private readonly IUsuarioCaching _usuarioCaching;

        public UsuarioApplicationService (
            IMediator mediator, 
            IUsuarioCaching usuarioCaching)
        {
            _mediator = mediator;
            _usuarioCaching = usuarioCaching;
        }

        public async Task Create(UsuarioCreateCommand command)
        {
            await _mediator.Send(command);
        }

        public async Task Update(UsuarioUpdateCommand command)
        {
            await _mediator.Send(command);
        }

        public async Task Delete(UsuarioDeleteCommand command)
        {
            await _mediator.Send(command);
        }

        public async Task<List<UsuarioModel>> GetAll()
        {
            return await _usuarioCaching.GetAll();
        }

        public async Task<UsuarioModel> GetById(Guid id)
        {
            return await _usuarioCaching.GetById(id);
        }
    }
}
