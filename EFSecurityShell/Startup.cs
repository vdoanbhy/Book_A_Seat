using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Book_A_Seat.Startup))]
namespace Book_A_Seat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
