using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Arrcen.ABPDemo.MultiTenancy.Dto;

namespace Arrcen.ABPDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
