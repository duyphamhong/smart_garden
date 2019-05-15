using Customer.Api.Model;

namespace Customer.Api.Infrastructure.Repositories
{
    public interface ICustomerRepository : IGenericRepository<Model.Customer>
    {
    }
    public class CustomerRepository : GenericRepository<CustomerDBContext, Model.Customer>, ICustomerRepository
    {
        public CustomerRepository(CustomerDBContext context) : base(context) { }
    }
}
