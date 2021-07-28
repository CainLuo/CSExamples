using System;

namespace DataTypeApplication {
    // 引用类型
    class objectData {
        static void objectMethod1() {
            object obj;
            obj = 100; // 装箱

            Console.WriteLine("Object: {0}", obj);
            Console.ReadLine();
        }

        static void objectMethod2() {
            int val = 8;
            object obj = val; // 整型数据转换为对象类型（装箱）

            Console.WriteLine("Object: {0}", obj);
            Console.ReadLine();
        }

        static void objectMethod3() {
            int val = 8;
            object obj = val; // 先装箱
            int nval = (int)obj; // 再拆箱
        }
    }

    // 动态类型
    class dynamitObject {
        dynamic d = 20;
    }

    // 字符串
    class stringObject {
        String str = "Hello world";

        // 转义字符串，@等价于\\
        static void transferredMeaning() {
            string str = @"c:\Windows";
            string str1 = "c:\\Windows";

            // @可以任意换行
            string str2 = @"<script type>=""text/javascript"">
            <!--    -->
            </script>";
        }

        static void configCharTypes() {
            char myChar = 'a';
            string myString1 = "";
            string myString2 = "a";
        }
    }

    // 布尔类型
    class boolObject {
        static void configBoolTypes() {
            bool myBool = false;
        }
    }


    // 指针类型
    //class pointerTypes {
    //    char* cptr;
    //    int* iptr;
    //}

    class MainClass {
        public static void Main(string[] args) {
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.ReadLine();

            configIntTypes();
            configFloatTypes();
        }

        // 整型类型
        // byte的长度是0~255
        static void configIntTypes() {
            byte myByte = 25;

            int score = 6000;

            long count = 1000000300;

            Console.WriteLine("byte: {0}, int: {1}, long: {2}", myByte, score, count);
        }

        // 浮点类型
        static void configFloatTypes() {
            float myFloat = 12.5f;
            double myDouble = 12.6;
            Console.WriteLine("float: {0}, double: {1}", myFloat, myDouble);
        }
    }
}