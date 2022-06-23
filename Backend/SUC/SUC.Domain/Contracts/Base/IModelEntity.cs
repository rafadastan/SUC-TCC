using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Contracts.BaseModelEntity
{
    public interface IModelEntity<ObjectId>
    {
        ObjectId id { get; }
    }
}
