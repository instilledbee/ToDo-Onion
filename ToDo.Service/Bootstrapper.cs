using Nancy;
using Nancy.Bootstrapper;
using Nancy.Configuration;
using Nancy.Diagnostics;
using Nancy.TinyIoc;
using ToDo.Core.Business;
using ToDo.Core.Interfaces;

namespace ToDo.Service
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        public override void Configure(INancyEnvironment environment)
        {
            environment.Diagnostics(true, "X@mar1n");
            environment.Tracing(true, true);
            base.Configure(environment);
        }
        
        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);

            container.Register<IToDoManager, ToDoManagerMock>();
        }
    }
}