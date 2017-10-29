using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsAndFields
{
    class Sigleton
    {
        private static Sigleton _sigleton=new Sigleton();
        public static Sigleton GetSigleton => _sigleton;
        static Sigleton()
        {
            _sigleton = new Sigleton();
        }
        private Sigleton()
        {

        }
    }

    class SigletonV1
    {
        public static SigletonV1 GetSigleton => temp._sigletonV1;

        private class temp
        {

            public static SigletonV1 _sigletonV1 = new SigletonV1();

            static temp()
            {
            }
        }

        static SigletonV1()
        {
        }

        private SigletonV1()
        {

        }
    }
    class SigletonV2
    {
        public static SigletonV2 GetSigleton => Nested._instance;


        class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            //static Nested()
            //{
            //}

            internal static readonly SigletonV2 _instance = new SigletonV2();
        }

        static SigletonV2()
        {
        }

        private SigletonV2()
        {

        }
    }
}
