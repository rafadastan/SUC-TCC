using SUC.Domain.Models.Indice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.Caching
{
    public interface IIndiceCaching : IBaseCaching<IndiceModel, Guid>
    {
    }
}
