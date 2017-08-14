using Abp.Web.Mvc.Views;

namespace Arrcen.ABPDemo.Web.Views
{
    public abstract class ABPDemoWebViewPageBase : ABPDemoWebViewPageBase<dynamic>
    {

    }

    public abstract class ABPDemoWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ABPDemoWebViewPageBase()
        {
            LocalizationSourceName = ABPDemoConsts.LocalizationSourceName;
        }
    }
}