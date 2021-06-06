using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartWarehouseWeb.EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWarehouseWeb.Configurations
{
    public class ORDER_DETAILSConfiguration : IEntityTypeConfiguration<ORDER_DETAILS>
    {
        public void Configure(EntityTypeBuilder<ORDER_DETAILS> builder)
        {
            throw new NotImplementedException();
        }
    }
}
