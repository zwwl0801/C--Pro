using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectTest.MyAttribute
{
    [MyTestAtt("id1","1.0.0","des")]
    class MyUseAtt
    {
        public int myField;
    }
}
