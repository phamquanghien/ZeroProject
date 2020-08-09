using Abp.Application.Services;
using ABPNetCore.MultiTenancy.Dto;

namespace ABPNetCore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

