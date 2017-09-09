using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures.Lock
{
    public class DeadLock
    {
        private static readonly object Obj = new object();
        public void DeadLockTest(int i)
        {
            lock (Obj)   //或者lock一个静态object变量
            {
                if (i > 10)
                {
                    Console.WriteLine(i--);

                    DeadLockTest(i);
                }
            }
        }
    }
}
