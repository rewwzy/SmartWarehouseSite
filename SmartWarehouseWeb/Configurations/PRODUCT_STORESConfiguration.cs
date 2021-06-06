using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartWarehouseWeb.EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWarehouseWeb.Configurations
{
    public class PRODUCT_STORESConfiguration : IEntityTypeConfiguration<PRODUCT_STORES>
    {
        public void Configure(EntityTypeBuilder<PRODUCT_STORES> builder)
        {
            throw new NotImplementedException();
        }
    }
}
