using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PreFinalQuiz1_Manalang.Startup))]
namespace PreFinalQuiz1_Manalang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
