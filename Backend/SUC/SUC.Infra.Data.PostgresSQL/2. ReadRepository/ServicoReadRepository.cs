using SUC.Domain.Contracts.Infra.ReadRepository;
using SUC.Domain.Models.Servico;
using SUC.Infra.Data.PostgresSQL_ReadRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL._2._ReadRepository
{
    public class ServicoReadRepository : BaseReadRepository<ServicoModel, Guid>, IServicoReadRepository
    {
    }
}
