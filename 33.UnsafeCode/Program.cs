using System;

namespace UnsafeCodeApplication {
    class MyClass {
        public static void Main(string[] args) {
            UnsafeCodeClass.logMethod();
            Console.WriteLine();

            UnsafeCodeClass.logMethod2();
            Console.WriteLine();

            TestPointer.logMethod();
            Console.WriteLine();

            TestPointer.logMethod2();

            Console.ReadLine();
        }
    }
}