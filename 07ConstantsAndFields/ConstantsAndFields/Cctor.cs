using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsAndFields
{
    class Cctor
    {
        //.method private hidebysig specialname rtspecialname static
        //        void  .cctor() cil managed
        //    {
        //  // 代码大小       12 (0xc)
        //  .maxstack  8
        //  IL_0000:  ldstr      "lvrh"
        //  IL_0005:  stsfld     string ConstantsAndFields.Cctor::_name
        //  IL_000a:  nop
        //  IL_000b:  ret
        //} // end of method Cctor::.cctor
        private static string _name = "lvrh";

        static Cctor()
        {

        }
    }

    class CctorV1
    {
        //.method private hidebysig specialname rtspecialname static
        //void  .cctor() cil managed
        //{
        //// 代码大小       12 (0xc)
        //.maxstack  8
        //IL_0000:  nop
        //IL_0001:  ldstr      "lvrh"
        //IL_0006:  stsfld     string ConstantsAndFields.CctorV1::_name
        //IL_000b:  ret
        //} // end of method CctorV1::.cctor
        private static string _name;
        static CctorV1()
        {
            _name = "lvrh";
        }
    }

    class CctorV2
    {
        //.method private hidebysig specialname rtspecialname static
        //void  .cctor() cil managed
        //{
        //// 代码大小       11 (0xb)
        //.maxstack  8
        //IL_0000:  ldstr      "lvrh"
        //IL_0005:  stsfld     string ConstantsAndFields.CctorV2::_name
        //IL_000a:  ret
        //} // end of method CctorV2::.cctor
        private static string _name = "lvrh";
    }
}
