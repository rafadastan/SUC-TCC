using Microsoft.Extensions.DependencyInjection;
using SUC.Application.Contracts.Auth;
using SUC.Application.Contracts.Perfil;
using SUC.Application.Contracts.Usuario;
using SUC.Application.Services.Auth;
using SUC.Application.Services.Perfil;
using SUC.Application.Services.Usuario;
using SUC.CrossCutting.Cryptography;
using SUC.Domain.Contracts.Cryptography;
using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Contracts.Infra.ReadRepository;
using SUC.Domain.Contracts.Infra.Repository;
using SUC.Infra.Data.MongoDB.Caching;
using SUC.Infra.Data.PostgresSQL._3._Repository;
using SUC.Infra.Data.PostgresSQL_ReadRepository;
using SUC.Infra.Data.PostgresSQL_Repository;
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
            #endregion

            #region Domain

            #endregion

            #region Infra
            services.AddTransient<IPerfilCaching, PerfilCaching>();
            services.AddTransient<IUsuarioCaching, UsuarioCaching>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IPerfilRepository, PerfilRepository>();

            services.AddTransient<IUsuarioReadRepository, UsuarioReadRepository>();

            #endregion

            #region Cryptography
            services.AddTransient<IMD5Cryptoghaphy, MD5Cryptography>();
            #endregion
        }
    }
}
