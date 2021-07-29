using System;

namespace CalculatorApplication {

    class NumberManipulator {
        public int FindMax(int num1, int num2) {
            /* 局部变量声明 */
            int result;

            if (num1 > num2) {
                result = num1;
            } else {
                result = num2;
            }

            return result;
        }

        // 递归方法
        public int factorial(int num) {
            /* 局部变量定义 */
            int result;

            if (num == 1) {
                return 1;
            } else {
                result = factorial(num - 1) * num;
                return result;
            }
        }

        // 交换两个数值
        public void swap(int x, int y) {
            int temp;

            Console.WriteLine("在交换之前，x 的值： {0}", x);
            Console.WriteLine("在交换之前，y 的值： {0}", y);
            temp = x;
            x = y;
            y = temp;

            Console.WriteLine("在交换之后，x 的值： {0}", x);
            Console.WriteLine("在交换之后，y 的值： {0}\n", y);
        }

        public void swap2(int x, int y) {
            Console.WriteLine("在交换之前，x 的值： {0}", x);
            Console.WriteLine("在交换之前，y 的值： {0}", y);

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine("在交换之后，x 的值： {0}", x);
            Console.WriteLine("在交换之后，y 的值： {0}\n", y);
        }

        public void swap3(int x, int y) {
            Console.WriteLine("在交换之前，x 的值： {0}", x);
            Console.WriteLine("在交换之前，y 的值： {0}", y);

            x = x * y;
            y = x / y;
            x = x / y;

            Console.WriteLine("在交换之后，x 的值： {0}", x);
            Console.WriteLine("在交换之后，y 的值： {0}\n", y);
        }

        public void swap4(int x, int y) {
            Console.WriteLine("在交换之前，x 的值： {0}", x);
            Console.WriteLine("在交换之前，y 的值： {0}", y);

            x ^= y;
            y ^= x;
            x ^= y;

            Console.WriteLine("在交换之后，x 的值： {0}", x);
            Console.WriteLine("在交换之后，y 的值： {0}\n", y);
        }

        // 按输出传递参数
        public void getValue(out int x) {
            int temp = 5;
            x = temp;
        }

        public void getValue2(out int x, out int y) {
            Console.WriteLine("请输入第一个值:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个值:");
            y = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Test {
        static void Main(string[] args) {
            /* 局部变量定义 */
            int a = 100;
            int b = 200;
            int ret;
            NumberManipulator n = new NumberManipulator();

            //调用 FindMax 方法
            ret = n.FindMax(a, b);
            Console.WriteLine("最大值是： {0}\n", ret);

            //调用 factorial 方法
            Console.WriteLine("6 的阶乘是： {0}", n.factorial(6));
            Console.WriteLine("7 的阶乘是： {0}", n.factorial(7));
            Console.WriteLine("8 的阶乘是： {0}\n", n.factorial(8));

            // 调用swap方法
            n.swap(a, b);
            n.swap2(a, b);
            n.swap3(a, b);
            n.swap4(a, b);

            // 调用函数来获取值
            Console.WriteLine("在方法调用之前，a 的值： {0}", a);
            n.getValue(out a);
            Console.WriteLine("在方法调用之后，a 的值： {0}", a);

            int x;
            int y;

            n.getValue2(out x, out y);

            Console.WriteLine("在方法调用之后，x 的值： {0}", x);
            Console.WriteLine("在方法调用之后，y 的值： {0}", y);

            Console.ReadLine();
        }
    }
}