using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SUC.Application.Contracts.Atendimento;
using SUC.Application.Contracts.Auth;
using SUC.Application.Contracts.Avaliacao;
using SUC.Application.Contracts.Catalago;
using SUC.Application.Contracts.Chamado;
using SUC.Application.Contracts.Contato;
using SUC.Application.Contracts.Demanda;
using SUC.Application.Contracts.Departamento;
using SUC.Application.Contracts.Endereco;
using SUC.Application.Contracts.Indice;
using SUC.Application.Contracts.Informacao;
using SUC.Application.Contracts.Orgao;
using SUC.Application.Contracts.Perfil;
using SUC.Application.Contracts.Servico;
using SUC.Application.Contracts.Solicitacao;
using SUC.Application.Contracts.Usuario;
using SUC.Application.Services;
using SUC.Application.Services.Atendimento;
using SUC.Application.Services.Auth;
using SUC.Application.Services.Avaliacao;
using SUC.Application.Services.Catalago;
using SUC.Application.Services.Chamado;
using SUC.Application.Services.Contato;
using SUC.Application.Services.Demanda;
using SUC.Application.Services.Departamento;
using SUC.Application.Services.Indice;
using SUC.Application.Services.Informacao;
using SUC.Application.Services.Orgao;
using SUC.Application.Services.Perfil;
using SUC.Application.Services.Servico;
using SUC.Application.Services.Solicitacao;
using SUC.Application.Services.Usuario;
using SUC.CrossCutting.Cryptography;
using SUC.Domain.Contracts.Auth;
using SUC.Domain.Contracts.Cryptography;
using SUC.Domain.Contracts.Infra;
using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Contracts.Infra.ReadRepository;
using SUC.Domain.Contracts.Infra.ReadRepositoryEndereco;
using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Infra.RepositoryAgenda;
using SUC.Domain.Contracts.Perfils;
using SUC.Domain.Contracts.Services;
using SUC.Domain.Contracts.Usuarios;
using SUC.Domain.Services;
using SUC.Domain.Services.Auth;
using SUC.Infra.Data.MongoDB.Caching;
using SUC.Infra.Data.PostgresSQL._2._ReadRepository;
using SUC.Infra.Data.PostgresSQL._3._Repository;
using SUC.Infra.Data.PostgresSQL.Contexts;
using SUC.Infra.Data.PostgresSQL.ReadRepository;
using SUC.Infra.Data.PostgresSQL.ReadRepositoryEndereco;
using SUC.Infra.Data.PostgresSQL.Repository;
using SUC.Infra.Data.PostgresSQL_ReadRepository;
using SUC.Infra.Data.PostgresSQL_Repository;
using SUC.Security.UserContext;

namespace SUC.CrossCutting.IOC
{
    public class AddDependencyInjection
    {
        public static void AddDependencyInjections(IServiceCollection services)
        {
            #region Application
            services.AddTransient<IAgendaApplicationService, AuthApplicationService>();
            services.AddTransient<IPerfilApplicationService, PerfilApplicationService>();
            services.AddTransient<IUsuarioApplicationService, UsuarioApplicationService>();
            services.AddTransient<IUsuarioApplicationService, UsuarioApplicationService>();
            services.AddTransient<IContatoApplicationService, ContatoApplicationService>();
            services.AddTransient<IEnderecoApplicationService, EnderecoApplicationService>();
            services.AddTransient<IAtendimentoApplicationService, AtendimentoApplicationService>();
            services.AddTransient<IAvaliacaoApplicationService, AvaliacaoApplicationService>();
            services.AddTransient<ICatalagoApplicationService, CatalagoApplicationService>();
            services.AddTransient<IChamadoApplicationService, ChamadoApplicationService>();
            services.AddTransient<IDemandaApplicationService, DemandaApplicationService>();
            services.AddTransient<IDepartamentoApplicationService, DepartamentoApplicationService>();
            services.AddTransient<IIndiceApplicationService, IndiceApplicationService>();
            services.AddTransient<IInformacaoApplicationService, InformacaoApplicationService>();
            services.AddTransient<IOrgaoApplicationService, OrgaoApplicationService>();
            services.AddTransient<IServicoApplicationService, ServicoApplicationService>();
            services.AddTransient<ISolicitacaoApplicationService, SolicitacaoApplicationService>();
            #endregion

            #region Domain
            services.AddTransient<IAuthDomainService, AuthDomainService>();
            services.AddTransient<IPerfilDomainService, PerfilDomainService>();
            services.AddTransient<IUsuarioDomainService, UsuarioDomainService>();
            services.AddTransient<IContatoDomainService, ContatoDomainService>();
            services.AddTransient<IEnderecoDomainService, EnderecoDomainService>();
            services.AddTransient<IAtendimentoDomainService, AtendimentoDomainService>();
            services.AddTransient<IAgendaDomainService, AgendaDomainService>();
            services.AddTransient<IAvaliacaoDomainService, AvaliacaoDomainService>();
            services.AddTransient<ICatalagoDomainService, CatalagoDomainService>();
            services.AddTransient<IChamadoDomainService, ChamadoDomainService>();
            services.AddTransient<IDemandaDomainService, DemandaDomainService>();
            services.AddTransient<IDepartamentoDomainService, DepartamentoDomainService>();
            services.AddTransient<IIndiceDomainService, IndiceDomainService>();
            services.AddTransient<IInformacaoDomainService, InformacaoDomainService>();
            services.AddTransient<IOrgaoDomainService, OrgaoDomainService>();
            services.AddTransient<IServicoDomainService, ServicoDomainService>();
            services.AddTransient<ISolicitacaoDomainService, SolicitacaoDomainService>();
            #endregion

            #region Infra
            services.AddTransient<IPerfilCaching, PerfilCaching>();
            services.AddTransient<IUsuarioCaching, UsuarioCaching>();
            services.AddTransient<IContatoCaching, ContatoCaching>();
            services.AddTransient<IEnderecoCaching, EnderecoCaching>();
            services.AddTransient<IAgendaCaching, AgendaCaching>();
            services.AddTransient<IAtendimentoCaching, AtendimentoCaching>();
            services.AddTransient<IAvaliacaoCaching, AvaliacaoCaching>();
            services.AddTransient<ICatalagoCaching, CatalagoCaching>();
            services.AddTransient<IChamadoCaching, ChamadoCaching>();
            services.AddTransient<IDemandaCaching, DemandaCaching>();
            services.AddTransient<IDepartamentoCaching, DepartamentoCaching>();
            services.AddTransient<IIndiceCaching, IndiceCaching>();
            services.AddTransient<IInformacaoCaching, InformacaoCaching>();
            services.AddTransient<IOrgaoCaching, OrgaoCaching>();
            services.AddTransient<IServicoCaching, ServicoCaching>();
            services.AddTransient<ISolicitacaoCaching, SolicitacaoCaching>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IPerfilRepository, PerfilRepository>();
            services.AddTransient<IContatoRepository, ContatoRepository>();
            services.AddTransient<IEnderecoRepository, EnderecoRepository>();
            services.AddTransient<IAgendaRepository, AgendaRepository>();
            services.AddTransient<IAtendimentoRepository, AtendimentoRepository>();
            services.AddTransient<IAvaliacaoRepository, AvaliacaoRepository>();
            services.AddTransient<ICatalagoRepository, CatalagoRepository>();
            services.AddTransient<IChamadoRepository, ChamadoRepository>();
            services.AddTransient<IDemandaRepository, DemandaRepository>();
            services.AddTransient<IDepartamentoRepository, DepartamentoRepository>();
            services.AddTransient<IIndiceRepository, IndiceRepository>();
            services.AddTransient<IInformacaoRepository, InformacaoRepository>();
            services.AddTransient<IOrgaoRepository, OrgaoRepository>();
            services.AddTransient<IServicoRepository, ServicoRepository>();
            services.AddTransient<ISolicitacaoRepository, SolicitacaoRepository>();

            services.AddTransient<IUsuarioReadRepository, UsuarioReadRepository>();
            services.AddTransient<IPerfilReadRepository, PerfilReadRepository>();
            services.AddTransient<IContatoReadRepository, ContatoReadRepository>();
            services.AddTransient<IEnderecoReadRepository, EnderecoReadRepository>();
            services.AddTransient<IAgendaReadRepository, AgendaReadRepository>();
            services.AddTransient<IAtendimentoReadRepository, AtendimentoReadRepository>();
            services.AddTransient<IAvaliacaoReadRepository, AvaliacaoReadRepository>();
            services.AddTransient<ICatalagoReadRepository, CatalagoReadRepository>();
            services.AddTransient<IChamadoReadRepository, ChamadoReadRepository>();
            services.AddTransient<IDemandaReadRepository, DemandaReadRepository>();
            services.AddTransient<IDepartamentoReadRepository, DepartamentoReadRepository>();
            services.AddTransient<IIndiceReadRepository, IndiceReadRepository>();
            services.AddTransient<IInformacaoReadRepository, InformacaoReadRepository>();
            services.AddTransient<IOrgaoReadRepository, OrgaoReadRepository>();
            services.AddTransient<IServicoReadRepository, ServicoReadRepository>();
            services.AddTransient<ISolicitacaoReadRepository, SolicitacaoReadRepository>();

            services.AddScoped<DbSession>();
            #endregion

            #region Cryptography
            services.AddTransient<IMD5Cryptoghaphy, MD5Cryptography>();
            #endregion

            #region Security
            services.AddTransient<IUserContext, UserHttpContext>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            #endregion
        }
    }
}
