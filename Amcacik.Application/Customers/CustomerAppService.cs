﻿using Abp.Application.Services;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Linq.Extensions;

namespace Amcacik.Customers
{
    public class CustomerAppService : AsyncCrudAppService<Customer, CustomerDto>, ICustomerAppService
    {
        public CustomerAppService(IRepository<Customer> repository) : base(repository)
        {
            
        }
    }
}
