using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RajBillPay.Startup))]
namespace RajBillPay
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
