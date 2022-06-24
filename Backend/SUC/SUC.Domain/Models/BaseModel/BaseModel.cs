using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SUC.Domain.Models.Usuario;
using System.Text.Json.Serialization;

namespace SUC.Domain.ModelsBases
{
    public abstract class BaseModel<T> : TenantModel<T>
    {
        public T Model { get; set; }
    }

    public abstract class TenantModel<T> 
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public ObjectId _id;
    }
}
