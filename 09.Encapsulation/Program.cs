using System;

namespace RectangleApplication {

    class Rectangle {
        //成员变量
        private double length;
        private double width;

        public void Acceptdetails() {
            Console.WriteLine("请输入长度：");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入宽度：");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea() {
            return length * width;
        }
        public void Display() {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}\n", GetArea());
        }
    }
    //end class Rectangle

    class Rectangle1 {
        //成员变量
        internal double length;
        internal double width;

        public double GetArea() {
            return length * width;
        }
        public void Display() {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}", GetArea());
        }
    }
    //end class Rectangle1

    class ExecuteRectangle {
        static void Main(string[] args) {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();

            Rectangle1 r1 = new Rectangle1();

            r1.length = 4.5;
            r1.width = 3.5;
            r1.Display();

            Console.ReadLine();
        }
    }
}

/*
 (1) Pubilc ：任何公有成员可以被外部的类访问。
 (2) Private ：只有同一个类中的函数可以访问它的私有成员。
 (3) Protected ：该类内部和继承类中可以访问。
 (4) internal : 同一个程序集的对象可以访问。
 (5) Protected internal ：3 和 4 的并集，符合任意一条都可以访问。
*/ 