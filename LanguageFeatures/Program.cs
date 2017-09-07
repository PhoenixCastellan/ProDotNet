using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageFeatures.GcAndDispose;
using LanguageFeatures.Indexer;
using LanguageFeatures.Lock;

namespace LanguageFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(TestIndexer.UseIndexerByNumber());
            //Console.WriteLine(TestIndexer.UseIndexerByString()); 
            //Console.WriteLine(TestIndexer.UseIndexerByObject());
            //Console.WriteLine(TestIndexer.UseIndexerByMultiParam());

            //TestResourceHolder.Test("GcAndDispose\\Dispose·finalize·GC·析构函数区别.txt");
            //TestResourceHolder.TestByUseUsing("GcAndDispose\\Dispose·finalize·GC·析构函数区别.txt");

            DeadLock dl = new DeadLock();
            dl.DeadLockTest(20);
            Console.ReadKey();
        }
    }
}
