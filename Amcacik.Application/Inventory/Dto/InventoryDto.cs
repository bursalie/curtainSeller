using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Amcacik.Inventories
{
    [AutoMap(typeof(Inventory))]
    public class InventoryDto:FullAuditedEntityDto<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime EntryDateTime { get; set; }
        public DateTime ExitDateTime { get; set; }
        public string CompanyName { get; set; }
        public int PackAmount { get; set; }
        public decimal Metrage { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
