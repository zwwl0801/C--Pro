using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zw.ReflectTest
{
    delegate string TestDelegate(string value);
    class MyReflectType
    {
        public string myStr;
        public MyReflectType()
        {
        }
        public MyReflectType(string _str) 
        {
            myStr = _str;
        }

        public void MethodWithNoParaNoReturn()
        {
            Console.WriteLine("不带参数且不返回值的方法");
        }

        public string MethodWithNoPara()
        {
            Console.WriteLine("不带参数且有返回值的方法");
            return "MethodWithNoPara";
        }

        public string Method1(string str)
        {
            Console.WriteLine("带参数且有返回值的方法");
            return str;
        }

        public string Method2(string str, int index)
        {
            Console.WriteLine("带参数且有返回值的方法");
            return str + index.ToString();
        }

        public string Method3(string str, out string outStr)
        {
            outStr = "bbbb";
            Console.WriteLine("带参数且有返回值的方法");
            return str;
        }

        public static string StaticMethod()
        {
            Console.WriteLine("静态方法");
            return "cccc";
        }
        public void ReturnConsole()
        {
            Console.WriteLine("myStr = " + myStr);
            Console.WriteLine("调用了ReturnConsole方法");
        }
        public void ReturnConsole(string str)
        {
            Console.WriteLine("调用了ReturnConsole方法,参数是：" + str);
        }
        public static void StaticReturnConsole()
        {
            Console.WriteLine("调用了static ReturnConsole方法");
        }
        public string ReturnMyDelegate(string str)
        {
            Console.WriteLine("调用了ReturnMyDelegate方法,参数是：" + str);
            return str;
        }
        public void TestDelegate() 
        {
        }
    }
}
