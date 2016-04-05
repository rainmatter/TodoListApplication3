using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TodoListApplication3.Startup))]
namespace TodoListApplication3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
