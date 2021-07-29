using System;
using System.Text.RegularExpressions;

namespace RegExApplication {
    class Program {
        private static void showMatch1(string text, string expr) {
            Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc) {
                Console.WriteLine(m);
            }
        }

        public static void logMethod1() {
            string str = "A Thousand Splendid Suns";

            Console.WriteLine("Matching words that start with 'S': ");
            showMatch1(str, @"\bS\S*");
        }

        private static void showMatch2(string text, string expr) {
            Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc) {
                Console.WriteLine(m);
            }
        }

        public static void logMethod2() {
            string str = "make maze and manage to measure it";

            Console.WriteLine("Matching words start with 'm' and ends with 'e':");
            showMatch2(str, @"\bm\S*e\b");
        }
    }

    class MyClass {
        static void Main(string[] args) {

            Program.logMethod1();
            Console.WriteLine("\n");

            Program.logMethod2();


            Console.ReadKey();
        }
    }
}