using System.Web;

namespace AspxPageLifeCycle.HttpHandle
{
    public class MyHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext cont)
        {
            //cont.Response.Write("This Is MyHandler ." + "<br />");
        }

        public bool IsReusable
        {
            get { return true; }
        }
    }
}