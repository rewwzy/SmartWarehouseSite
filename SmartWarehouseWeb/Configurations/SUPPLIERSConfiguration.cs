using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartWarehouseWeb.EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWarehouseWeb.Configurations
{
    public class SUPPLIERSConfiguration : IEntityTypeConfiguration<SUPPLIERS>
    {
        public void Configure(EntityTypeBuilder<SUPPLIERS> builder)
        {
            throw new NotImplementedException();
        }
    }
}
