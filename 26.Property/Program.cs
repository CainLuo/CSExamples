//using System;
//namespace tutorialspoint {

//    public abstract class Person {

//        // 抽象属性，由子类实现
//        public abstract string Name1 {
//            get;
//            set;
//        }
//        public abstract int Age1 {
//            get;
//            set;
//        }
//    }

//    class Student : Person {

//        private string code = "N.A";
//        private string name = "not known";
//        private int age = 0;

//        private string name1 = "not known";
//        private int age1 = 0;

//        // 声明类型为 string 的 Code 属性
//        public string Code {
//            get {
//                return code;
//            }
//            set {
//                code = value;
//            }
//        }

//        // 声明类型为 string 的 Name 属性
//        public string Name {
//            get {
//                return name;
//            }
//            set {
//                name = value;
//            }
//        }

//        // 声明类型为 int 的 Age 属性
//        public int Age {
//            get {
//                return age;
//            }
//            set {
//                age = value;
//            }
//        }

//        // 重载父类的抽象属性
//        public override string Name1 {
//            get {
//                return name1;
//        }
//            set {
//                name1 = value;
//            }
//        }

//        public override int Age1 {
//            get {
//                return age1;
//            }
//            set {
//                age1 = value;
//            }
//        }

//        public override string ToString() {
//            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age + ", Name1 = " + Name1 + ", Age1 = " + Age1;
//        }
//    }
//    class ExampleDemo {
//        public static void Main() {
//            // 创建一个新的 Student 对象
//            Student s = new Student();

//            // 设置 student 的 code、name 和 age
//            s.Code = "001";
//            s.Name = "Zara";
//            s.Age = 9;

//            // 设置父类的name1和age1
//            s.Name1 = "小明";
//            s.Age1 = 15;

//            Console.WriteLine("Student Info: {0}", s);
//            // 增加年龄
//            s.Age += 1;
//            Console.WriteLine("Student Info: {0}", s);
//            Console.ReadKey();
//        }
//    }
//}

// 简化版
using System;

namespace Demo.cs {
    class Program {

        public abstract class Person {
            public abstract string Name { get; set; }
            public abstract int Age { get; set; }
        }

        public class Student : Person {
            public string Code { get; set; } = "N.A";
            public override string Name { get; set; } = "N.A";
            public override int Age { get; set; } = 0;
            public override string ToString() {
                return $"Code:{Code},Name:{Name},Age:{Age}";
            }
        }

        static void Main(string[] args) {
            var s = new Student() {
                Code = "001",
                Name = "Zara",
                Age = 10
            };
            Console.WriteLine($"Student Info:={s}");

            s.Age++;
            Console.WriteLine($"Student Info:={s}");
            Console.ReadKey();
        }
    }
}