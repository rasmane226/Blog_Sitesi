using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Blog_Sitesi.Models.Context
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ALPEREN\SQLEXPRESS;database=Blog_Sitesi;integrated security=true;");
        }
        public DbSet<Communication> Communications { get; set; }
    }
}
