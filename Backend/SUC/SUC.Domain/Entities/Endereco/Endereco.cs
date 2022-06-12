using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Domain.Entities.EntityEndereco
{
    public class Endereco
    {
        public Guid IdEndereco { get; set; }
        public Guid? IdUsuario { get; set; }
        public string EnderecoNome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid? CreatorUserId { get; set; }
        public DateTime? LastModificationDate { get; set; }
        public Guid? LastModifierUserId { get; set; }

        public Usuario Usuario { get; set; }
    }
}
