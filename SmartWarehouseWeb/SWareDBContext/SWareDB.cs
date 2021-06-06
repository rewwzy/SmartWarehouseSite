using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWarehouseWeb.SWareDBContext
{
    public class SWareDB : DbContext
    {
        public SWareDB(DbContextOptions<SWareDB> options)
         : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.ApplyConfiguration(new FStudentConfiguration());

            //Data Seeding
            //modelBuilder.Seed();//Sau đó tiến hành chạy lại lệnh add-migration +  update-database

        }
    }
}
