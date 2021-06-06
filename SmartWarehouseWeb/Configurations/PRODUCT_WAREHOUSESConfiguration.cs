using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartWarehouseWeb.EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWarehouseWeb.Configurations
{
    public class PRODUCT_WAREHOUSESConfiguration : IEntityTypeConfiguration<PRODUCT_WAREHOUSES>
    {
        public void Configure(EntityTypeBuilder<PRODUCT_WAREHOUSES> builder)
        {
            throw new NotImplementedException();
        }
    }
}
