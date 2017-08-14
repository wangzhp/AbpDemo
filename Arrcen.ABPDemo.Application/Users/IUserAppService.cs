using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Arrcen.ABPDemo.Roles.Dto;
using Arrcen.ABPDemo.Users.Dto;

namespace Arrcen.ABPDemo.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}