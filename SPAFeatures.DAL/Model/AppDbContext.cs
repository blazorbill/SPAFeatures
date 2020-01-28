
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPAFeatures.DAL.Model
{
    public class AppDbContext: DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
