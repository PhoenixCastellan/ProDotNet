using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspxPageLifeCycle.HttpHandle
{
    public class HandleAll:IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("handle all");
        }

        public bool IsReusable { get; }
    }
}