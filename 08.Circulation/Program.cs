using System;

namespace Circulation {
    class MainClass {
        public static void Main(string[] args) {
            //infiniteLoop();
            //whileLoop();
            //forLoop();
            //foreachLoop();
            doWhileLoop();
            Console.ReadLine();
        }

        // 无限循环
        static void infiniteLoop() {
            int a = 0;
            for (; ; ) {
                Console.WriteLine("Hello World!");
                a += 1;
                if (a == 100) {
                    Console.WriteLine("Stop loop, loop count: {0}", a);
                    break;
                }
            }
        }

        // while循环
        static void whileLoop() {
            int a = 0;
            bool condition = true;
            while(condition) {
                a += 1;
                Console.WriteLine("Stop loop, loop count: {0}", a);

                if (a == 100) {
                    condition = false;
                }
            }
        }

        // for循环
        static void forLoop() {
            for(int a = 0; a < 20; a += 1) {
                Console.WriteLine("a的值: {0}", a);
            }
        }

        // for-earch循环
        static void foreachLoop() {
            int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int element in fibarray) {
                Console.WriteLine(element);
            }
            Console.WriteLine();


            // 类似 foreach 循环
            for (int i = 0; i < fibarray.Length; i++) {
                Console.WriteLine(fibarray[i]);
            }
            Console.WriteLine();


            // 设置集合中元素的计算器
            int count = 0;
            foreach (int element in fibarray) {
                count += 1;
                Console.WriteLine("Element #{0}: {1}", count, element);
            }
            Console.WriteLine("Number of elements in the array: {0}", count);
        }

        // do-while循环
        static void doWhileLoop() {
            int a = 10;

            do {
                a -= 1;
                Console.WriteLine("a: {0}", a);
            } while (a > 0);
        }
    }
}
