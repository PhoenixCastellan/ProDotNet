using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsAndFields
{
    class Program
    {
        static void Main(string[] args)
        {

            Sigleton a = Sigleton.GetSigleton;
            Sigleton b =Sigleton.GetSigleton;

            SigletonV1 a1 = SigletonV1.GetSigleton;
            SigletonV1 b1 = SigletonV1.GetSigleton;


        }
    }

    abstract class AbstractType
    {

    }

    static class SystemInfo
    {
        public static string Name = "lvrh";
    }

    public sealed class SomeLibraryType
    {
        private static Int32 s_x=1;
        static SomeLibraryType()
        {
            s_x = 5;
        }
    }

    
}
