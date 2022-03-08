using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Contexts
{
    public class DbSession
    {
        private Guid Id;
        public IDbConnection Connection { get; }
        public IDbTransaction Transaction { get; set; }

        public DbSession()
        {
            Id = Guid.NewGuid();
            Connection = new NpgsqlConnection(Settings.Configure());
            Connection.Open();
        }

    }
}
