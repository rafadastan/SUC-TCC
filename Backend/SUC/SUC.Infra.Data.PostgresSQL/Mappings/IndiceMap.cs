using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities.Indices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Mappings
{
    public class IndiceMap : IEntityTypeConfiguration<Indice>
    {
        public void Configure(EntityTypeBuilder<Indice> builder)
        {
            throw new NotImplementedException();
        }
    }
}
