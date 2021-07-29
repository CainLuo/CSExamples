using System;

namespace Array {

    class ArrayClass {
        public void arrayMethod1() {
            double[] balance = new double[10];
            Console.WriteLine("balance: {0}", balance);

            balance[0] = 4500.0;

            for (int i = 0; i < balance.Length; i++) {
                Console.WriteLine("Element[{0}]: {1}", i, balance[i]);
            }
        }

        public void arrayMethod2() {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] = i + 100;
            }

            foreach(int j in numbers) {
                int i = j - 100;
                Console.WriteLine("Element[{0}]: {1}", i, j);
                i++;
            }
        }

        // 二维数组：C# 支持多维数组。多维数组最简单的形式是二维数组。
        public void arrayMethod3() {
            int[,] a = new int[3, 4] {
                {0, 1, 2, 3},
                {4, 5, 6, 7},
                {8, 9, 10, 11}
            };

            int i, j;

            /* 输出数组中每个元素的值 */
            for (i = 0; i < 3; i++) {
                for (j = 0; j < 4; j++) {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
                }
            }
        }

        // 交错数组：C# 支持交错数组，即数组的数组。
        public void arrayMethod4() {
            /* 一个由 5 个整型数组组成的交错数组 */
            int[][] a = new int[][] {
                new int[]{0, 0},
                new int[]{1, 2},
                new int[]{2, 4},
                new int[]{3, 6},
                new int[]{4, 8}
            };

            int i, j;

            /* 输出数组中每个元素的值 */
            for (i = 0; i < 5; i++) {
                for (j = 0; j < 2; j++) {
                    Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]);
                }
            }
        }

        // 传递数组给函数：您可以通过指定不带索引的数组名称来给函数传递一个指向数组的指针。
        public void arrayMethod5() {
            /* 一个带有 5 个元素的 int 数组 */
            int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            double avg;

            /* 传递数组的指针作为参数 */
            avg = getAverage(balance, balance.Length);

            /* 输出返回值 */
            Console.WriteLine("平均值是： {0} ", avg);
        }

        private double getAverage(int[] arr, int size) {
            int i;
            double avg;
            int sum = 0;

            for (i = 0; i < size; ++i) {
                sum += arr[i];
            }

            avg = (double)sum / size;
            return avg;
        }

        // 参数数组：这通常用于传递未知数量的参数给函数。
        public int AddElements(params int[] arr) {
            int sum = 0;
            foreach (int i in arr) {
                sum += i;
            }
            return sum;
        }

        // 数组的属性及内部方法
        public void arrayMethod6() {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = list;

            Console.Write("原始数组： ");
            foreach (int i in list) {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 逆转数组
            System.Array.Reverse(temp);
            Console.Write("逆转数组： ");
            foreach (int i in temp) {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 排序数组
            System.Array.Sort(list);
            Console.Write("排序数组： ");
            foreach (int i in list) {
                Console.Write(i + " ");
            }
        }
    }

    class MainClass {
        public static void Main(string[] args) {

            ArrayClass array = new ArrayClass();

            array.arrayMethod1();
            Console.WriteLine("\n");

            array.arrayMethod2();
            Console.WriteLine("\n");

            array.arrayMethod3();
            Console.WriteLine("\n");

            array.arrayMethod4();
            Console.WriteLine("\n");

            array.arrayMethod5();
            Console.WriteLine("\n");

            int sum = array.AddElements(512, 720, 250, 567, 889);
            Console.WriteLine("总和是： {0}\n", sum);

            array.arrayMethod6();
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
