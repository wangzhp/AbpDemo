using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using Arrcen.ABPDemo.Authorization.Users;
using Arrcen.ABPDemo.MultiTenancy;
using Arrcen.ABPDemo.Users;
using Microsoft.AspNet.Identity;

namespace Arrcen.ABPDemo
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ABPDemoAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected ABPDemoAppServiceBase()
        {
            LocalizationSourceName = ABPDemoConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}