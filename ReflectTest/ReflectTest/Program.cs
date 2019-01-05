using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Zw.ReflectTest;

using ReflectTest.MyAttribute;
namespace MethodInfoInvokeDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            //Type可以获取对象的类型信息，包括方法，构造器，属性等。
            Type type = typeof(MyReflectType);
            object reflectTest = Activator.CreateInstance(type);

            //MethodInfo包含方法信息，方法名，参数，返回值
            MethodInfo methodInfo = type.GetMethod("MethodWithNoParaNoReturn");

            //不带参数且不返回值的方法的调用
            methodInfo.Invoke(reflectTest, null);
            Console.WriteLine();

            //不带参数且有返回值的方法的调用
            methodInfo = type.GetMethod("MethodWithNoPara");
            Console.WriteLine(methodInfo.Invoke(reflectTest, null).ToString());
            Console.WriteLine();

            //带参数且有返回值的方法的调用
            methodInfo = type.GetMethod("Method1", new Type[] { typeof(string) });
            Console.WriteLine(methodInfo.Invoke(reflectTest, new object[] { "测试" }).ToString());
            Console.WriteLine();

            //带多个参数且有返回值的方法的调用
            methodInfo = type.GetMethod("Method2", new Type[] { typeof(string), typeof(int) });
            Console.WriteLine(methodInfo.Invoke(reflectTest, new object[] { "测试", 100 }).ToString());

            //Console.WriteLine();

            //methodInfo = type.GetMethod("Method3", new Type[] { typeof(string), typeof(string) });
            //string outStr = "";
            //Console.WriteLine(methodInfo.Invoke(reflectTest, new object[] { "测试", outStr }).ToString());

            Console.WriteLine();

            //静态方法的调用
            methodInfo = type.GetMethod("StaticMethod");
            Console.WriteLine(methodInfo.Invoke(null, null).ToString());
            Console.WriteLine();

            Type type1 = typeof(MyReflectType);
            Object[] constructParms = new object[] { "wo shi canshu 1" };
            MyReflectType reflectTest1 = (MyReflectType)Activator.CreateInstance(type1, constructParms);
            reflectTest1.ReturnConsole();
            reflectTest1.ReturnConsole("wo shi canshu 2");
            
            TestAttribute();
            
            Console.ReadKey();
        }

        public static void TestAttribute()
        {
            MyUseAtt myuse = new MyUseAtt();
            Type t = myuse.GetType();

            bool isDefined = t.IsDefined(typeof(MyTestAttAttribute),false);
            if (isDefined)
            {
                Console.WriteLine("MyTestAtt is applied to type {0}", t.Name);
            }

            object[] AttArr = t.GetCustomAttributes(false);
            foreach (Attribute item in AttArr)
            {
                MyTestAttAttribute attr = item as MyTestAttAttribute;
                if (attr != null)
                {
                    Console.WriteLine("attr.attID : {0}", attr.attID);
                    Console.WriteLine("attr.versionNumber : {0}", attr.versionNumber);
                    Console.WriteLine("attr.description : {0}", attr.description);
                }
                
            }

        }


    }
}

