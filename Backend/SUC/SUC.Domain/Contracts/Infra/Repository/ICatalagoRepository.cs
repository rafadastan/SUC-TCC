using SUC.Domain.Entities.Catalago;
using SUC.Domain.Models.Catalago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Infra.Repository
{
    public interface ICatalagoRepository : IBaseRepository<Catalago, Guid>
    {
    }
}
