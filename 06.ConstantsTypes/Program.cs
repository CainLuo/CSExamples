using System;

namespace LetTypes {
    class MainClass {
        public static void Main(string[] args) {
            Console.WriteLine("Hello\tWorld!\n\n");

            constMethod();

            Console.ReadLine();
        }

        // 声明常量的方法
        static void constMethod() {
            const double pi = 3.14159; // 声明常量
            double r;
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
        }
    }
}

// 整数常量
/*
 212         // 合法
 215u        // 合法
 0xFeeL      // 合法
 078         // 非法：8 不是一个八进制数字
 032UU       // 非法：不能重复后缀
*/

/*
 85         // 十进制 
 0213       // 八进制 
 0x4b       // 十六进制 
 30         // int 
 30u        // 无符号 int
 30l        // long 
 30ul       // 无符号 long
 */

// 浮点常量
/*
 3.14159      // 合法
 314159E-5L   // 合法
 510E         // 非法：不完全的指数
 210f         // 非法：没有小数或指数
 .e55         // 非法：缺少整数或小数
*/

// 字符常量
/* 
 * \\           // \字符
 * \'           // '字符
 * \"           // "字符
 * \?           // ?字符
*/ 