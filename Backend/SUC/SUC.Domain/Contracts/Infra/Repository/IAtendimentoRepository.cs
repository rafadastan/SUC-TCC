using SUC.Domain.Entities.Atendimento;
using SUC.Domain.Models.Atendimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.Repository
{
    public interface IAtendimentoRepository : IBaseRepository<Atendimento, Guid>
    {
    }
}
