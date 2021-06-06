using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartWarehouseWeb.EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWarehouseWeb.Configurations
{
    public class CATEGORIESConfiguration : IEntityTypeConfiguration<CATEGORIES>
    {
        public void Configure(EntityTypeBuilder<CATEGORIES> builder)
        {
            throw new NotImplementedException();
        }
    }
}
