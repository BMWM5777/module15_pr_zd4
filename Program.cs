using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace module15_pr_zd4
{
    class MyClass
    {
        private int privateField;
        public int PublicField;

        private MyClass() { }

        public MyClass(int value)
        {
            privateField = value;
            PublicField = value;
        }

        private void PrivateMethod()
        {
            Console.WriteLine("Private method called");
        }

        public void PublicMethod()
        {
            Console.WriteLine("Public method called");
        }
    }
    class Program
    {
        static void Main()
        {
            Type myClassType = typeof(MyClass);
            object myObject = Activator.CreateInstance(myClassType);

            MethodInfo privateMethod = myClassType.GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance);
            privateMethod.Invoke(myObject, null);
        }
    }

}
