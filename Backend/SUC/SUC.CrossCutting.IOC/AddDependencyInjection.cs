using Microsoft.Extensions.DependencyInjection;
using SUC.Application.Contracts.Auth;
using SUC.Application.Contracts.Perfil;
using SUC.Application.Services.Auth;
using SUC.Application.Services.Perfil;
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
            #endregion

            #region Domain

            #endregion

            #region Infra

            #endregion

            #region Cryptography

            #endregion
        }
    }
}
