using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.Base
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}
