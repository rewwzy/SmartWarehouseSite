using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartWarehouseWeb.EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWarehouseWeb.Configurations
{
    public class TYPE_OF_PRODUCTSConfiguration : IEntityTypeConfiguration<TYPE_OF_PRODUCTS>
    {
        public void Configure(EntityTypeBuilder<TYPE_OF_PRODUCTS> builder)
        {
            throw new NotImplementedException();
        }
    }
}
