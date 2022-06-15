using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SUC.Application.Contracts.Auth;
using SUC.Application.Contracts.Contato;
using SUC.Application.Contracts.Endereco;
using SUC.Application.Contracts.Perfil;
using SUC.Application.Contracts.Usuario;
using SUC.Application.Services;
using SUC.Application.Services.Auth;
using SUC.Application.Services.Contato;
using SUC.Application.Services.Perfil;
using SUC.Application.Services.Usuario;
using SUC.CrossCutting.Cryptography;
using SUC.Domain.Contracts.Auth;
using SUC.Domain.Contracts.Cryptography;
using SUC.Domain.Contracts.Infra;
using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Contracts.Infra.ReadRepository;
using SUC.Domain.Contracts.Infra.ReadRepositoryEndereco;
using SUC.Domain.Contracts.Infra.Repository;
using SUC.Domain.Contracts.Perfils;
using SUC.Domain.Contracts.Services;
using SUC.Domain.Contracts.Usuarios;
using SUC.Domain.Services;
using SUC.Domain.Services.Auth;
using SUC.Infra.Data.MongoDB.Caching;
using SUC.Infra.Data.PostgresSQL._2._ReadRepository;
using SUC.Infra.Data.PostgresSQL._3._Repository;
using SUC.Infra.Data.PostgresSQL.Contexts;
using SUC.Infra.Data.PostgresSQL.ReadRepositoryEndereco;
using SUC.Infra.Data.PostgresSQL_ReadRepository;
using SUC.Infra.Data.PostgresSQL_Repository;
using SUC.Security.UserContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.CrossCutting.IOC
{
    public class AddDependencyInjection
    {
        public static void AddDependencyInjections(IServiceCollection services)
        {
            #region Application
            services.AddTransient<IAuthApplicationService, AuthApplicationService>();
            services.AddTransient<IPerfilApplicationService, PerfilApplicationService>();
            services.AddTransient<IUsuarioApplicationService, UsuarioApplicationService>();
            services.AddTransient<IUsuarioApplicationService, UsuarioApplicationService>();
            services.AddTransient<IContatoApplicationService, ContatoApplicationService>();
            services.AddTransient<IEnderecoApplicationService, EnderecoApplicationService>();
            #endregion

            #region Domain
            services.AddTransient<IAuthDomainService, AuthDomainService>();
            services.AddTransient<IPerfilDomainService, PerfilDomainService>();
            services.AddTransient<IUsuarioDomainService, UsuarioDomainService>();
            services.AddTransient<IContatoDomainService, ContatoDomainService>();
            services.AddTransient<IEnderecoDomainService, EnderecoDomainService>();
            #endregion

            #region Infra
            services.AddTransient<IPerfilCaching, PerfilCaching>();
            services.AddTransient<IUsuarioCaching, UsuarioCaching>();
            services.AddTransient<IContatoCaching, ContatoCaching>();
            services.AddTransient<IEnderecoCaching, EnderecoCaching>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IPerfilRepository, PerfilRepository>();
            services.AddTransient<IContatoRepository, ContatoRepository>();
            services.AddTransient<IEnderecoRepository, EnderecoRepository>();

            services.AddTransient<IUsuarioReadRepository, UsuarioReadRepository>();
            services.AddTransient<IPerfilReadRepository, PerfilReadRepository>();
            services.AddTransient<IContatoReadRepository, ContatoReadRepository>();
            services.AddTransient<IEnderecoReadRepository, EnderecoReadRepository>();

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
