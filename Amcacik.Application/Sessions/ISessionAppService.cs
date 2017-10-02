﻿using System.Threading.Tasks;
using Abp.Application.Services;
using Amcacik.Sessions.Dto;

namespace Amcacik.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
