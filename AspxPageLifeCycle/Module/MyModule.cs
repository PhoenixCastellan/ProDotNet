using System;
using System.Web;

namespace AspxPageLifeCycle.Module
{
    public class MyModule : IHttpModule

    {
        public void Dispose()
        {
        }

        public void Init(HttpApplication app)
        {
            app.BeginRequest += new EventHandler(this.Application_BeginRequest);
            app.EndRequest += new EventHandler(this.Application_EndRequest);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpApplication app = sender as HttpApplication;
            app.Context.Response.Write("This Is MyModule Application_BeginRequest .");
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            HttpApplication app = sender as HttpApplication;
            app.Context.Response.Write("This Is MyModule Application_EndRequest .");
        }
    }
}