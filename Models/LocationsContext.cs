using System;
using Microsoft.EntityFrameworkCore;

namespace Locations.Models
{
    public class LocationsContext:DbContext
    {
        public LocationsContext()
        {
        }

        public DbSet<Location> Locations { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseMySql(@"Server=localhost;Port=8889;database=ToDoListWithMigrations;uid=root;pwd=root;");
		}

		public LocationsContext(DbContextOptions<LocationsContext> options)
            : base(options)
        {
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
    }
}
