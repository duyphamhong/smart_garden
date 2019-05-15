using Microsoft.EntityFrameworkCore;

namespace Customer.Api.Model
{
    public class CustomerDBContext : DbContext
    {
        public CustomerDBContext(DbContextOptions<CustomerDBContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }

    }
}
