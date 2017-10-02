using Abp.Web.Mvc.Views;

namespace Amcacik.Web.Views
{
    public abstract class AmcacikWebViewPageBase : AmcacikWebViewPageBase<dynamic>
    {

    }

    public abstract class AmcacikWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AmcacikWebViewPageBase()
        {
            LocalizationSourceName = AmcacikConsts.LocalizationSourceName;
        }
    }
}