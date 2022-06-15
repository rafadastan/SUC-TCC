using SUC.Domain.Contracts.Infra.ReadRepositoryEndereco;
using SUC.Domain.Models.Endereco;
using SUC.Infra.Data.PostgresSQL_ReadRepository;
using System;

namespace SUC.Infra.Data.PostgresSQL.ReadRepositoryEndereco
{
    public class EnderecoReadRepository : BaseReadRepository<EnderecoModel, Guid>, IEnderecoReadRepository
    {
    }
}
