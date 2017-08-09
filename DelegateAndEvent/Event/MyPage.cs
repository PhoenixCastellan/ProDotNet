using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.Event
{
    public class MyPage
    {
        private MyControl ctl1=new MyControl("a");
        private MyControl ctl2=new MyControl("b");

        public MyPage()
        {
            ctl1.on_a_click += on_a1_click;
            ctl1.on_z_click += on_z_click;
            ctl2.on_a_click += on_a1_click;
            ctl2.on_z_click += on_z_click;

            ctl1.Run();
            ctl2.Run();
        }

        static void on_a1_click(object sender, KeyCharArgs e)
        {
            Console.WriteLine("a is click:" + e.Char);
        }

        static void on_z_click(object sender, KeyCharArgs e)
        {
            Console.WriteLine("z is click:"+e.Char);
        }

    }
}
