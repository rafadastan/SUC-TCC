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
        IAgenciaRepository AgenciaRepository { get; }
        IAtendimentoRepository AtendimentoRepository { get; }
        IAvaliacaoRepository AvaliacaoRepository { get; }
        ICatalagoRepository CatalagoRepository { get; }
        IChamadoRepository ChamadoRepository { get; }
        IDemandaRepository DemandaRepository { get; }
        IDepartamentoRepository DepartamentoRepository { get; }
        IIndiceRepository IndiceRepository { get; }
        IInformacaoRepository InformacaoRepository { get; }
        IOrgaoRepository OrgaoRepository { get; }
        IServicoRepository ServicoRepository { get; }
        ISolicitacaoRepository SolicitacaoRepository { get; }
        #endregion
    }
}
