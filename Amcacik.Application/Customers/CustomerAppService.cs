using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;

namespace Amcacik.Customers
{
    public class CustomerAppService: AsyncCrudAppService<Customer, CustomerDto>,ICustomerAppService
    {
        public CustomerAppService(IRepository<Customer> repository) : base(repository)
        {
            
        }
    }
}
