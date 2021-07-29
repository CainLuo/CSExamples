
using System;

namespace Class {
    class Box {
        public double length;   // 长度
        public double breadth;  // 宽度
        public double height;   // 高度

        public static void boxMethod1() {
            Box Box1 = new Box();        // 声明 Box1，类型为 Box
            Box Box2 = new Box();        // 声明 Box2，类型为 Box
            double volume = 0.0;         // 体积

            // Box1 详述
            Box1.height = 5.0;
            Box1.length = 6.0;
            Box1.breadth = 7.0;

            // Box2 详述
            Box2.height = 10.0;
            Box2.length = 12.0;
            Box2.breadth = 13.0;

            // Box1 的体积
            volume = Box1.height * Box1.length * Box1.breadth;
            Console.WriteLine("Box1 的体积： {0}", volume);

            // Box2 的体积
            volume = Box2.height * Box2.length * Box2.breadth;
            Console.WriteLine("Box2 的体积： {0}\n", volume);
        }
    }

    class Box1 {
        private double length;   // 长度
        private double breadth;  // 宽度
        private double height;   // 高度
        public void setLength(double len) {
            length = len;
        }

        public void setBreadth(double bre) {
            breadth = bre;
        }

        public void setHeight(double hei) {
            height = hei;
        }
        public double getVolume() {
            return length * breadth * height;
        }

        public static void boxMethod1() {
            Box1 Box1 = new Box1();        // 声明 Box1，类型为 Box
            Box1 Box2 = new Box1();        // 声明 Box2，类型为 Box
            double volume;              // 体积


            // Box1 详述
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            // Box2 详述
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);

            // Box1 的体积
            volume = Box1.getVolume();
            Console.WriteLine("Box1 的体积： {0}", volume);

            // Box2 的体积
            volume = Box2.getVolume();
            Console.WriteLine("Box2 的体积： {0}\n", volume);
        }
    }

    class Line {
        private double length;   // 线条的长度
        public Line() {
            Console.WriteLine("对象已创建");
        }

        public void setLength(double len) {
            length = len;
        }
        public double getLength() {
            return length;
        }

        public static void lineMethod1() {
            Line line = new Line();
            // 设置线条长度
            line.setLength(6.0);
            Console.WriteLine("线条的长度： {0}\n", line.getLength());
        }
    }

    class Line1 {
        private double length;   // 线条的长度
        public Line1(double len)  // 参数化构造函数
        {
            Console.WriteLine("对象已创建，length = {0}", len);
            length = len;
        }

        public void setLength(double len) {
            length = len;
        }
        public double getLength() {
            return length;
        }

        public static void lineMethod1() {
            Line1 line = new Line1(10.0);
            Console.WriteLine("线条的长度： {0}", line.getLength());
            // 设置线条长度
            line.setLength(6.0);
            Console.WriteLine("线条的长度： {0}\n", line.getLength());
        }
    }

    class Line2 {
        private double length;   // 线条的长度
        // 构造函数
        public Line2() {
            Console.WriteLine("对象已创建");
        }

        //析构函数
        ~Line2() {
            Console.WriteLine("对象已删除\n");
        }

        public void setLength(double len) {
            length = len;
        }
        public double getLength() {
            return length;
        }

        public static void lineMethod1() {
            Line2 line = new Line2();
            // 设置线条长度
            line.setLength(6.0);
            Console.WriteLine("线条的长度： {0}", line.getLength());
        }
    }

    class StaticVar {
        public static int num;
        public void count() {
            num++;
        }
        public int getNum() {
            return num;
        }

        public static void staticMethod1() {
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();
            s1.count();
            s1.count();
            s1.count();
            s2.count();
            s2.count();
            s2.count();
            Console.WriteLine("s1 的变量 num： {0}", s1.getNum());
            Console.WriteLine("s2 的变量 num： {0}\n", s2.getNum());
        }
    }

    class StaticVar1 {
        public static int num;
        public void count() {
            num++;
        }
        public static int getNum() {
            return num;
        }

        public static void staticMethod1() {
            StaticVar s = new StaticVar();
            s.count();
            s.count();
            s.count();
            Console.WriteLine("变量 num： {0}", StaticVar1.getNum());
        }
    }

    class MainClass {
        public static void Main(string[] args) {
            Box.boxMethod1();
            Box1.boxMethod1();
            Line.lineMethod1();
            Line1.lineMethod1();
            Line2.lineMethod1();
            StaticVar.staticMethod1();
            StaticVar1.staticMethod1();

            Console.ReadLine();
        }
    }
}