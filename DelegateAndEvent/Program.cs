using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DelegateAndEvent.Delegate;
using DelegateAndEvent.Event;

namespace DelegateAndEvent
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            TestEvent();
            TestDelegate();
            Console.Read();
        }

        static void TestEvent()
        {
            var page = new MyPage();
        }

        static void TestDelegate()
        {
            var md = new MyDelegate();
            md.SaySomeThing = new SaySomeThing(SayChinese);
            md.SaySomeThing += SayEnglish;
            md.SaySomeThing("hello world!");
        }

        static void SayChinese(string word)
        {
            Console.WriteLine($@"A chinese say {word}");
        }
        static void SayEnglish(string word)
        {
            Console.WriteLine($@"A en say {word}");
        }
    }
}
