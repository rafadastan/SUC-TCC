using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Mappings
{
    public class OrgaoMap : IEntityTypeConfiguration<Orgao>
    {
        public void Configure(EntityTypeBuilder<Orgao> builder)
        {
            throw new NotImplementedException();
        }
    }
}
