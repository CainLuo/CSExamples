using System;
using System.Collections.Generic;

namespace GenericApplication {
    class Tester {
        static void Main(string[] args) {

            GenericArray.logMethod();
            Console.WriteLine("\n");
            GenericDelegate.logMethod();

            Console.ReadKey();
        }
    }
}