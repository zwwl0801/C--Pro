using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectTest.MyAttribute
{
    [AttributeUsage(AttributeTargets.Class)]
    class MyTestAttAttribute:System.Attribute
    {
        public string attID;
        public string versionNumber;
        public string description;
        public MyTestAttAttribute()
        {
            Console.WriteLine("call MyTestAttAttribute()");
        }
        public MyTestAttAttribute(string id)
        {
            Console.WriteLine("call MyTestAttAttribute(string id)");
            attID = id;
        }
        public MyTestAttAttribute(string id, string _versionNumber)
        {
            Console.WriteLine("call MyTestAttAttribute(string id, string str)");
            attID = id;
            versionNumber = _versionNumber;
        }
        public MyTestAttAttribute(string id, string _versionNumber, string _description)
        {
            Console.WriteLine("call MyTestAttAttribute(string id, string str)");
            attID = id;
            versionNumber = _versionNumber;
            description = _description;
        }
    }
}
