using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SUC.Domain.Contracts.BaseModelEntity;
using SUC.Domain.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.ModelsBases
{
    public abstract class BaseModel<T> : TenantModel
    {
        public T Model { get; set; }
    }

    public abstract class TenantModel : IModelEntity<ObjectId>
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        protected abstract ObjectId _id { get; }
        public ObjectId id => _id;
    }
}
