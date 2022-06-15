using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.Repository
{
    public interface IUnitOfWork
    {
        #region Transaction Management

        void BeginTransaction();
        void Commit();
        void Rollback();
        void Save();

        #endregion

        #region Repositories

        IUsuarioRepository UsuarioRepository { get; }
        IPerfilRepository PerfilRepository { get; }
        IContatoRepository ContatoRepository { get; }
        IEnderecoRepository EnderecoRepository { get; }

        #endregion
    }
}
