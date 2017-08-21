using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspxPageLifeCycle
{
    public partial class SimpleTest : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {   //这里设置断点  
            Response.Write("执行Page_PreInit<br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {   //这里设置断点  
            Response.Write("执行Page_Init<br/>");
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {   //这里设置断点  
            Response.Write("执行Page_InitComplete<br/>");
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {   //这里设置断点  
            Response.Write("执行Page_PreLoad<br/>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {   //这里设置断点  
            Response.Write("执行Page_Load<br/>");
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {   //这里设置断点  
            Response.Write("执行Page_LoadComplete<br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {   //这里设置断点  
            Response.Write("执行Page_PreRender<br/>");
        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {   //这里设置断点  
            Response.Write("执行Page_PreRenderComplete<br/>");
        }
        protected void Page_SaveStateComplete(object sender, EventArgs e)
        {   //这里设置断点  
            Response.Write("执行Page_SaveStateComplete<br/>");
        }
        protected void Page_Unload(object sender, EventArgs e)
        {   //这里设置断点  
            //这里是页面卸载阶段，不能使用Response.Write方法，一般该事件内执行释放本页面控制的系统资源  
        }

        protected void aspbtn_TestPostBack_Click(object sender, EventArgs e)
        {
            Response.Write("执行Button控件的Click事件<br/>");
        }
    }
}