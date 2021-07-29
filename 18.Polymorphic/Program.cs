using System;
namespace PolymorphismApplication {
    class Printdata {
        void print(int i) {
            Console.WriteLine("Printing int: {0}", i);
        }

        void print(double f) {
            Console.WriteLine("Printing float: {0}", f);
        }

        void print(string s) {
            Console.WriteLine("Printing string: {0}", s);
        }

        public static void logMethod() {
            Printdata p = new Printdata();
            // 调用 print 来打印整数
            p.print(5);
            // 调用 print 来打印浮点数
            p.print(500.263);
            // 调用 print 来打印字符串
            p.print("Hello C++");
        }
    }

    /*
     * abstract: 创建抽象类
     * 规则：
     * 您不能创建一个抽象类的实例。
     * 您不能在一个抽象类外部声明一个抽象方法。
     * 通过在类定义前面放置关键字 sealed，可以将类声明为密封类。当一个类被声明为 sealed 时，它不能被继承。抽象类不能被声明为 sealed。
     */

    abstract class Shape {
        public abstract int area();
    }
    class Rectangle : Shape {
        private int length;
        private int width;
        public Rectangle(int a = 0, int b = 0) {
            length = a;
            width = b;
        }
        public override int area() {
            Console.WriteLine("Rectangle 类的面积：");
            return (width * length);
        }

        public static void logMethod() {
            Rectangle r = new Rectangle(10, 7);
            double a = r.area();
            Console.WriteLine("面积： {0}", a);
        }
    }

    /*
     虚方法: 可以在不同的继承类中有不同的实现。对虚方法的调用是在运行时发生的。
     */
    class Shape1 {
        protected int width, height;
        public Shape1(int a = 0, int b = 0) {
            width = a;
            height = b;
        }
        public virtual int area() {
            Console.WriteLine("父类的面积：");
            return 0;
        }
    }
    class Rectangle1 : Shape1 {
        public Rectangle1(int a = 0, int b = 0) : base(a, b) {

        }
        public override int area() {
            Console.WriteLine("Rectangle 类的面积：");
            return (width * height);
        }
    }
    class Triangle : Shape1 {
        public Triangle(int a = 0, int b = 0) : base(a, b) {

        }
        public override int area() {
            Console.WriteLine("Triangle 类的面积：");
            return (width * height / 2);
        }
    }
    class Caller {
        public void CallArea(Shape1 sh) {
            int a;
            a = sh.area();
            Console.WriteLine("面积： {0}", a);
        }

        public static void logMethod() {
            Caller c = new Caller();
            Rectangle1 r = new Rectangle1(10, 7);
            Triangle t = new Triangle(10, 5);
            c.CallArea(r);
            c.CallArea(t);
        }
    }

    class MainClass {
        static void Main(string[] args) {

            Printdata.logMethod();
            Console.WriteLine("\n");

            Rectangle.logMethod();
            Console.WriteLine("\n");

            Caller.logMethod();

            Console.ReadKey();
        }
    }
}

/*
 * 抽象方法和虚方法的区别
 * 虚方法必须有实现部分，抽象方法没有提供实现部分，抽象方法是一种强制派生类覆盖的方法，否则派生类将不能被实例化。
 * 抽象方法只能在抽象类中声明，虚方法不是。如果类包含抽象方法，那么该类也是抽象的，也必须声明类是抽象的。
 * 抽象方法必须在派生类中重写，这一点和接口类似，虚方法不需要再派生类中重写。
 */