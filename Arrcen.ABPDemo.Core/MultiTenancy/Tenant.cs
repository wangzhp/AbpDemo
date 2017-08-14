using Abp.MultiTenancy;
using Arrcen.ABPDemo.Authorization.Users;

namespace Arrcen.ABPDemo.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}