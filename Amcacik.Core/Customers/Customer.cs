using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace Amcacik.Customers
{
    public class Customer:Entity
    {
        public string No { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
