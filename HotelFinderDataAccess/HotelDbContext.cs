using HotelFinderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinderDataAccess
{
   public class HotelDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-RPUSQCK\\SQLEXPRESS;Database=HotelDB; Trusted_Connection = true;");
        }


        public DbSet<Hotel> Hotels{ get; set; }
    }
}