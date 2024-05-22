using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPro00
{
    struct MyStruct
    {
        public int x; 
        public int y;
    }
    internal class PassParamMetod
    {
        static void ArgExample(MyStruct number)
        {
            number.x = 191;
        }
        static void refArgExample(ref MyStruct number)
        {
            number.x = 191;
        }
        static void refreadonlyArgExample(ref readonly MyStruct number)
        {
         //  number.x = 191;
        }
        static void inArgExample(in MyStruct number)
        {
           // number.x = 191;
        }

    }
}