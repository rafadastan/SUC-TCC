using SUC.Domain.Contracts.Cryptography;
using SUC.Domain.Contracts.Infra.ReadRepository;
using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Usuarios;
using SUC.Domain.Entities;
using SUC.Domain.Models.Usuario;
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
        private readonly IUsuarioReadRepository _usuarioReadRepository;
        private readonly IMD5Cryptoghaphy _encrypt;

        public UsuarioDomainService(IUnitOfWork unitOfWork,
            IUsuarioReadRepository usuarioReadRepository, 
            IMD5Cryptoghaphy encrypt)
            : base(unitOfWork.UsuarioRepository)
        {
            _unitOfWork = unitOfWork;
            _usuarioReadRepository = usuarioReadRepository;
            _encrypt = encrypt;
        }

        public async Task<UsuarioModel> Get(string cpf, string senha)
        {
            senha = _encrypt.Encrypt(senha);

            return await _usuarioReadRepository.Get(cpf, senha);
        }

        public override async Task Create(Usuario entity)
        {
            entity.Senha = _encrypt.Encrypt(entity.Senha);

            await _unitOfWork
            .UsuarioRepository
            .Create(entity);

            _unitOfWork.Save();
        }
        public override async Task Update(Usuario entity)
        {
            await base.Update(entity);
        }

        public override async Task Delete(Usuario entity)
        {
            await _unitOfWork.UsuarioRepository.Delete(entity);
            _unitOfWork.Save();
        }

        public override async Task<Usuario> GetById(Guid id)
        {
            return await base.GetById(id);
        }

        public override async Task<List<Usuario>> GetAll()
        {
            return await base.GetAll();
        }        
    }
}
