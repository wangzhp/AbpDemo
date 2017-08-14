using Abp.AutoMapper;
using Arrcen.ABPDemo.Sessions.Dto;

namespace Arrcen.ABPDemo.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}