using System.Threading.Tasks;
using Abp.Application.Services;
using Arrcen.ABPDemo.Sessions.Dto;

namespace Arrcen.ABPDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
