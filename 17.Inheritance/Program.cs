using System;
namespace InheritanceApplication {
    class Shape {
        public void setWidth(int w) {
            width = w;
        }
        public void setHeight(int h) {
            height = h;
        }
        protected int width;
        protected int height;
    }

    // 派生类
    class Rectangle : Shape {
        public int getArea() {
            return (width * height);
        }

        public static void logMethod() {
            Rectangle Rect = new Rectangle();

            Rect.setWidth(5);
            Rect.setHeight(7);

            // 打印对象的面积
            Console.WriteLine("总面积： {0}\n", Rect.getArea());
        }
    }

    class Rectangle1 {
        // 成员变量
        protected double length;
        protected double width;
        public Rectangle1(double l, double w) {
            length = l;
            width = w;
        }
        public double GetArea() {
            return length * width;
        }
        public void Display() {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}", GetArea());
        }
    }//end class Rectangle

    class Tabletop : Rectangle1 {
        private double cost;
        public Tabletop(double l, double w) : base(l, w) { }
        public double GetCost() {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }
        public void Display() {
            base.Display();
            Console.WriteLine("成本： {0}\n", GetCost());
        }

        public static void logMethod() {
            Tabletop t = new Tabletop(4.5, 7.5);
            t.Display();
        }
    }

    // Double Inheritance
    class Shape1 {
        public void setWidth(int w) {
            width = w;
        }
        public void setHeight(int h) {
            height = h;
        }
        protected int width;
        protected int height;
    }

    // 基类 PaintCost
    public interface PaintCost {
        int getCost(int area);

    }
    // 派生类
    class Rectangle2 : Shape1, PaintCost {
        public int getArea() {
            return (width * height);
        }
        public int getCost(int area) {
            return area * 70;
        }

        public static void logMethod() {
            Rectangle2 Rect = new Rectangle2();
            int area;
            Rect.setWidth(5);
            Rect.setHeight(7);
            area = Rect.getArea();
            // 打印对象的面积
            Console.WriteLine("总面积： {0}", Rect.getArea());
            Console.WriteLine("油漆总成本： ${0}", Rect.getCost(area));
        }
    }

    class RectangleTester {
        static void Main(string[] args) {
            Rectangle.logMethod();

            Tabletop.logMethod();

            Rectangle2.logMethod();

            Console.ReadKey();
        }
    }
}