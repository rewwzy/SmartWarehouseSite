using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartWarehouseWeb.EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWarehouseWeb.Configurations
{
    public class SIZESConfiguration : IEntityTypeConfiguration<SIZES>
    {
        public void Configure(EntityTypeBuilder<SIZES> builder)
        {
            throw new NotImplementedException();
        }
    }
}
