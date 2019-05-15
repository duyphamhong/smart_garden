using Embedded.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Embedded.Api.Infrastructure.Repositories
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
    }
    public class CustomerRepository : GenericRepository<EmbeddedContext, Customer>, ICustomerRepository
    {
        public CustomerRepository(EmbeddedContext context) : base(context) { }
    }
}
