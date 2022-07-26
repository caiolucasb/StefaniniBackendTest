using ST.Repository.DataModel;
using Microsoft.EntityFrameworkCore;

namespace ST.Repository.Context
{
    public class PersonContext : DbContext
    {
        public PersonContext()
        {

        }
        public PersonContext(DbContextOptions<PersonContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }
    }
}
