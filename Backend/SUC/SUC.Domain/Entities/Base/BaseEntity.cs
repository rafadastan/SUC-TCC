using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities
{
    public abstract class BaseEntity
    {
        public virtual DateTime CreationDate { get; set; }
        public virtual Guid? CreatorUserId { get; set; }
        public virtual DateTime? LastModificationDate { get; set; }
        public virtual Guid? LastModifierUserId { get; set; }
    }
}
