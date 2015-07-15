using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_01.ChatRoom.Startup))]
namespace _01.ChatRoom
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
