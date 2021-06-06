using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartWarehouseWeb.EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWarehouseWeb.Configurations
{
    public class PRODUCTSConfiguration : IEntityTypeConfiguration<PRODUCTS>
    {
        public void Configure(EntityTypeBuilder<PRODUCTS> builder)
        {
            throw new NotImplementedException();
        }
    }
}
