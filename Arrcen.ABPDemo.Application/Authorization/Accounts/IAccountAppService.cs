using System.Threading.Tasks;
using Abp.Application.Services;
using Arrcen.ABPDemo.Authorization.Accounts.Dto;

namespace Arrcen.ABPDemo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
