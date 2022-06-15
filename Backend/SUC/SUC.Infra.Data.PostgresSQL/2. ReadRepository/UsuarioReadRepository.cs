using Dapper;
using SUC.Domain.Contracts.Infra.ReadRepository;
using SUC.Domain.Entities;
using SUC.Domain.Models;
using SUC.Domain.Models.Usuario;
using SUC.Infra.Data.PostgresSQL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL_ReadRepository
{
    public class UsuarioReadRepository : BaseReadRepository<UsuarioModel, Guid>, IUsuarioReadRepository
    {
        private DbSession _session;

        public UsuarioReadRepository(DbSession session)
        {
            _session = session;
        }

        public async Task<UsuarioModel> Get(string cpf, string senha)
        {
            var query = await _session
                .Connection
                .QueryAsync<UsuarioModel>(@"
                    SELECT * 
                        FROM usuario u 
                    WHERE u.""Cpf"" = @Cpf 
                    AND u.""Senha"" = @Senha", 
                new 
                {
                    Cpf = cpf,
                    Senha = senha
                });

            return query.FirstOrDefault();
        }
    }
}
