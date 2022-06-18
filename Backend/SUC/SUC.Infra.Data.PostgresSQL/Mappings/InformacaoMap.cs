using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities.Informacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Mappings
{
    public class InformacaoMap : IEntityTypeConfiguration<Informacao>
    {
        public void Configure(EntityTypeBuilder<Informacao> builder)
        {
            throw new NotImplementedException();
        }
    }
}
