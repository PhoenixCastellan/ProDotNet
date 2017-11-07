using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
        }


        class Family
        {
            private IList<string> _nameList;

            public Family(IList<string> namelist)
            {
                _nameList = namelist;
            }

            [IndexerName("Name")]
            public string this[int indexer]
            {
                get
                {
                    return _nameList[indexer];
                }

            }
        }
    }
}
