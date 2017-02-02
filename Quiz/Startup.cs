using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quiz.Startup))]
namespace Quiz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
