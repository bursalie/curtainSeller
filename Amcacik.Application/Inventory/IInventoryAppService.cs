﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;

namespace Amcacik.Inventories
{
    public interface IInventoryAppService : IAsyncCrudAppService<InventoryDto>
    {
    }
}
