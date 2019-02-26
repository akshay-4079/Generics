using System;

namespace GenericsEasy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MyGenericClass<string> strGenericClass = new MyGenericClass<string>("Hello World");
            MyGenericClass<int> intGenericClass = new MyGenericClass<int>(123456);
            MyGenericClass<double> doubleGenericClass = new MyGenericClass<double>(1234.56);
            int result1 = intGenericClass.genericMethod(1325);
            string result = strGenericClass.genericMethod("Akshay");
            double result2 = doubleGenericClass.genericMethod(1325.1234);
        }
    }
}
