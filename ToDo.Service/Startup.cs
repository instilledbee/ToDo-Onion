using System;
using Microsoft.AspNetCore.Builder;
using Nancy.Owin;

namespace ToDo.Service
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            try
            {
                app.UseOwin(x => x.UseNancy(y => y.Bootstrapper = new Bootstrapper()));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}