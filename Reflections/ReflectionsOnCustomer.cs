using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    public class ReflectionsOnCustomer
    {
        public static void Test() 
        {
            Type type = typeof(CustomerInfo);
            Console.WriteLine("Full Nme  of class is:"+type.FullName);
            Console.WriteLine("-------------------------------");
            //Printing Name of the class
            Console.WriteLine("Name is  :" + type.Name);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Methods used in our CustomerInfo Classs");
            //Method Information
            MethodInfo[] methods = type.GetMethods();

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name+":"+method.Name);
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Properties in our CustomerInfo Class");
            //Property Information
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name+":"+property.Name);
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Constructor in our customer info class");
            //Constructor Information
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Constuctor in our customer info class using late binding");

            ConstructorInfo[] constructorInfos = type.GetConstructors();
            foreach(ConstructorInfo constructor in constructorInfos)
            {
                Console.WriteLine(constructor.ToString());
            }

        }
    }
}
