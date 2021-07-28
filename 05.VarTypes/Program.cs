using System;

namespace VarTypes {
    class MainClass {
        public static void Main(string[] args) {
            short a = 10;
            int b = 20;
            double c = a + b;
            string name = "VarTypes";

            Console.WriteLine("{0}+{1}={2}", a,b,c);
            Console.WriteLine("name: {0}", name);
            Console.ReadLine();
        }
    }
}

/*
    int i, j, k;
    char c, ch;
    float f, salary;
    double d;

    int a = 100;

    int d = 3, f = 5;
    byte z = 22;
    double pi = 3.14159;
    char x = 'x';
*/