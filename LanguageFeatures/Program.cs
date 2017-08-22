using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageFeatures.Indexer;

namespace LanguageFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TestIndexer.UseIndexerByNumber());
            Console.WriteLine(TestIndexer.UseIndexerByString()); 
            Console.WriteLine(TestIndexer.UseIndexerByObject());
            Console.WriteLine(TestIndexer.UseIndexerByMultiParam());

            Console.ReadKey();
        }
    }
}
