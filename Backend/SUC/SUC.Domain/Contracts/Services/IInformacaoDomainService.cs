using SUC.Domain.Entities.Informacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Services
{
    public interface IInformacaoDomainService : IBaseDomainService<Informacao, Guid>
    {
    }
}
