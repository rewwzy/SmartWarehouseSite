using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartWarehouseWeb.EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWarehouseWeb.Configurations
{
    public class TYPE_OF_CATEGORIESConfiguration : IEntityTypeConfiguration<TYPE_OF_CATEGORIES>
    {
        public void Configure(EntityTypeBuilder<TYPE_OF_CATEGORIES> builder)
        {
            throw new NotImplementedException();
        }
    }
}
