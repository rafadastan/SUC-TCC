using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SUC.Domain.Entities.Catalago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.PostgresSQL.Mappings
{
    public class CatalagoMap : IEntityTypeConfiguration<Catalago>
    {
        public void Configure(EntityTypeBuilder<Catalago> builder)
        {
            throw new NotImplementedException();
        }
    }
}
