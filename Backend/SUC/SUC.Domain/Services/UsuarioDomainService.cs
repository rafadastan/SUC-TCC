using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Usuarios;
using SUC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Services
{
    public class UsuarioDomainService : BaseDomainService<Usuario, Guid>, IUsuarioDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsuarioDomainService(IUnitOfWork unitOfWork)
            : base(unitOfWork.UsuarioRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
