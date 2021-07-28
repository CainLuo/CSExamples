using System;

namespace TypeConversionApplication {
    class MainClass {
        public static void Main(string[] args) {
            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine("\n");
            Console.ReadKey();

            MainClass.StringToInt();
            MainClass.ExplicitConversion();
        }

        static void ExplicitConversion() {
            double d = 5673.74;
            int i;

            // 强制转换double为int
            i = (int)d;
            Console.WriteLine(i);
            Console.ReadKey();
        }

        static void StringToInt() {
            string locstr = 123.ToString();

            // 方法一：用Convert
            int i = Convert.ToInt16(locstr);

            // 方法二：用Parse
            int ii = int.Parse(locstr);

            Console.WriteLine(i);
            Console.WriteLine(ii);
            Console.ReadKey();
        }
    }
}
