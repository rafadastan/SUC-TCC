using SUC.Domain.Contracts.Infra.Caching;
using SUC.Domain.Models.Endereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.MongoDB.Caching
{
    public class EnderecoCaching : IEnderecoCaching
    {
        public Task Create(EnderecoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(EnderecoModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<EnderecoModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<EnderecoModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(EnderecoModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
