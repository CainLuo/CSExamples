using System;
using System.Diagnostics;

namespace Attribute {

    // 声明运行环境
    class ConditionalClass {
        [Conditional("DEBUG")]
        public static void Message(string msg) {
            Console.WriteLine(msg);
        }
    }

    // 声明过期方法
    class ObsoleteClass {
        // 如果为true，那么编译器就直接编译错误
        [Obsolete("Don't use oldMethod, user NewMethod instead", true)]
        public static void oldMethod() {
            Console.WriteLine("It is the old method");
        }

        public static void newMethod() {
            Console.WriteLine("Is is the new method");
        }
    }

    class Test {
        static void function1() {
            ConditionalClass.Message("In function1");
            function2();
        }

        static void function2() {
            ConditionalClass.Message("In function2");
        }

        public static void Main(string[] args) {
            ConditionalClass.Message("In Main function");
            function1();

            //ObsoleteClass.oldMethod();
            ObsoleteClass.newMethod();
            Console.WriteLine("\n");

            Rectangle rect = new Rectangle(10, 20);
            rect.Display();

            Console.ReadKey();
        }
    }
}
