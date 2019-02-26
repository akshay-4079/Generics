using System;

namespace GenericsHard
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Restricted Generics");
            MyGenericClass<string> strGenericClass1 = new MyGenericClass<string>("Hello World");

            strGenericClass1.genericMethod("Hello World!");

            MyGenericClass<Student> strGenericClass2 = new MyGenericClass<Student>(new Student());

            MyGenericClass1<Student> strGen = new MyGenericClass1<Student>(new Student());
            //MyGenericClass<int> intGenericClass = new MyGenericClass<int>(10);
            strGen.genericMethod1<string>(new Student(), "Hi");
            strGen.genericMethod1<string>(new Student(), "Hd");
    //strGen.genericMethod1<string>(new Student(), 123);
        }
    }


    class MyGenericClass<T> where T : class
    {
        private T genericMemberVariable;

        public MyGenericClass(T value)
        {
            genericMemberVariable = value;
        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);

            return genericMemberVariable;
        }

        public T genericProperty { get; set; }
    }
    class MyGenericClass1<T> where T : class
    {
        private T genericMemberVariable;

        public MyGenericClass1(T value)
        {
            genericMemberVariable = value;
        }
        public T genericMethod1<U>(T genericParameter, U anotherGenericType) where U : class
        {
               Console.WriteLine("In the Function");
                return genericParameter;

        }




    }

    public class Student
    {
    }

}
