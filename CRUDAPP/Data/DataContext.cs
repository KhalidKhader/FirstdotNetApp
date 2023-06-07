using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CRUDAPP.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options):base(options)
		{
		}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        
   

        public DbSet<SuperHero> SuperHeros { get; set; }
    }
}

