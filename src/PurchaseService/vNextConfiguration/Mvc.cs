using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace PurchaseService.vNextConfiguration
{
    internal static class Mvc
    {
        public static void ConfigurePurchaseMvc(this IServiceCollection services)
        {
            //services.AddMvc(options =>
            //{
            //    options.Filters.Add(new AuthorizeFilter(new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build()));
            //})
            //.AddJsonOptions(opt => {
            //    opt.SerializerSettings.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat;
            //    opt.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            //    opt.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //});
        }
    }
}
