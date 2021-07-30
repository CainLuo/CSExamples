﻿// 普通代理
//using System;

//delegate int NumberChanger(int n);

//namespace DelegateAppl {
//    class TestDelegate {
//        static int num = 10;
//        public static int AddNum(int p) {
//            num += p;
//            return num;
//        }

//        public static int MultNum(int q) {
//            num *= q;
//            return num;
//        }
//        public static int getNum() {
//            return num;
//        }

//        static void Main(string[] args) {
//            // 创建委托实例
//            NumberChanger nc1 = new NumberChanger(AddNum);
//            NumberChanger nc2 = new NumberChanger(MultNum);
//            // 使用委托对象调用方法
//            nc1(25);
//            Console.WriteLine("Value of Num: {0}", getNum());
//            nc2(5);
//            Console.WriteLine("Value of Num: {0}", getNum());
//            Console.ReadKey();
//        }
//    }
//}

// 多播代理
//using System;

//delegate int NumberChanger(int n);

//namespace DelegateAppl {

//    class TestDelegate {
//        static int num = 10;

//        public static int AddNum(int p) {
//            num += p;
//            Console.WriteLine("Value of Num: {0}, P: {1}", num, p);
//            return num;
//        }

//        public static int MultNum(int q) {
//            num *= q;
//            Console.WriteLine("Value of Num: {0}, Q: {1}", num, q);
//            return num;
//        }

//        public static int getNum() {
//            return num;
//        }

//        static void Main(string[] args) {
//            // 创建委托实例
//            NumberChanger nc;
//            NumberChanger nc1 = new NumberChanger(AddNum);
//            NumberChanger nc2 = new NumberChanger(MultNum);
//            nc = nc1;
//            //nc1(5);
//            //Console.WriteLine("Value of Num: {0}", getNum());
//            nc += nc2;
//            //nc2(2);
//            //Console.WriteLine("Value of Num: {0}", getNum());
//            // 调用多播
//            nc(5);
//            Console.WriteLine("Value of Num: {0}", getNum());
//            Console.ReadKey();
//        }
//    }
//}

// 输出代理
using System;
using System.IO;

namespace DelegateAppl {

    class PrintString {
        static FileStream fs;
        static StreamWriter sw;

        // 委托声明
        public delegate void printString(string s);

        // 该方法打印到控制台
        public static void WriteToScreen(string str) {
            Console.WriteLine("The String is: {0}", str);
        }

        // 该方法打印到文件
        public static void WriteToFile(string s) {
            fs = new FileStream("c:\\message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        // 该方法把委托作为参数，并使用它调用方法
        public static void sendString(printString ps) {
            ps("Hello World");
        }

        static void Main(string[] args) {
            printString ps1 = new printString(WriteToScreen);
            printString ps2 = new printString(WriteToFile);

            sendString(ps1);
            sendString(ps2);

            Console.ReadKey();
        }
    }
}