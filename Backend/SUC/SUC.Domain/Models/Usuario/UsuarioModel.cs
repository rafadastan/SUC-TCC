using System;
using MongoDB.Bson;
using SUC.Domain.Contracts.Base;
using SUC.Domain.Contracts.BaseModelEntity;
using SUC.Domain.ModelsBases;

namespace SUC.Domain.Models.Usuario
{
    public class UsuarioModel : TenantModel
    {
        public Guid IdUsuario { get; set; }
        public Guid IdPerfil { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public DateTime LastLogin { get; set; }

        protected override ObjectId _id => id;
    }
}
