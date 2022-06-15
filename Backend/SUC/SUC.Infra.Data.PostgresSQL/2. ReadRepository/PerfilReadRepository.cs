using Dapper;
using SUC.Domain.Contracts.Infra.ReadRepository;
using SUC.Domain.Enum;
using SUC.Domain.Models.Perfil;
using SUC.Infra.Data.PostgresSQL.Contexts;
using SUC.Infra.Data.PostgresSQL_ReadRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL._2._ReadRepository
{
    public class PerfilReadRepository : BaseReadRepository<PerfilModel, Guid>, IPerfilReadRepository
    {
        private DbSession _session;

        public PerfilReadRepository(DbSession session)
        {
            _session = session;
        }

        public async Task<PerfilModel> GetByProfile(DomainEnum.PerfilEnum perfilEnum)
        {
            var query = await _session
                .Connection
                .QueryAsync<PerfilModel>(@"
                    SELECT p.""IdPerfil"" as Id, p.* 
                        FROM perfil p 
                    WHERE p.""PerfilUsuario"" = @PerfilUsuario",
                new
                {
                    PerfilUsuario = perfilEnum
                });

            return query.FirstOrDefault();
        }
    }
}
