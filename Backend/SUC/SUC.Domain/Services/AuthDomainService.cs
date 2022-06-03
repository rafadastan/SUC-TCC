using SUC.Domain.Contracts.Auth;
using SUC.Domain.Contracts.Cryptography;
using SUC.Domain.Contracts.Infra.ReadRepository;
using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Entities;
using SUC.Domain.Models;
using SUC.Domain.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Services.Auth
{
    public class AuthDomainService : BaseDomainService<Usuario, Guid>, IAuthDomainService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUsuarioReadRepository _usuarioReadRepository;
        private readonly IMD5Cryptoghaphy _encrypt;

        public AuthDomainService(IUnitOfWork unitOfWork,
            IUsuarioReadRepository usuarioReadRepository, IMD5Cryptoghaphy encrypt)
            : base(unitOfWork.UsuarioRepository)
        {
            _unitOfWork = unitOfWork;
            _usuarioReadRepository = usuarioReadRepository;
            _encrypt = encrypt;
        }

        public async Task<AuthModel> Authentication(string cpf, string senha)
        {
            senha = _encrypt.Encrypt(senha);

            var authentication = await _usuarioReadRepository.Get(cpf, senha);

            if (authentication != null)
            {
                return new AuthModel
                {
                    Cpf = authentication.Cpf,
                    Created = authentication.Created,
                    Email = authentication.Email,
                    LastLogin = authentication.LastLogin,
                    Modified = authentication.Modified,
                    Nome = authentication.Nome
                };
            }

            return null;
        }
    }
}
