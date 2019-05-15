using Microsoft.EntityFrameworkCore;

namespace Embedded.Api.Model
{
    public class EmbeddedContext : DbContext
    {
        public EmbeddedContext(DbContextOptions<EmbeddedContext> options) : base(options)
        {
        }

        public DbSet<AirHumidity> AirHumidities { get; set; }
        public DbSet<AirTemperature> AirTemperatures { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<GroundHumidity> GroundHumidities { get; set; }
            
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ADMIN;Initial Catalog=ToI.Services.EmbeddedDb;User Id=sa;Password=Password@123;");
        }

    }
}
