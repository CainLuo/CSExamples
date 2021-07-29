using System;

namespace Enum {
    class EnumClass {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        public void enumMethod1() {
            int WeekDayStart = (int)Days.Mon;
            int WeekDayEnd = (int)Days.Fri;

            Console.WriteLine("Monday: {0}", WeekDayStart);
            Console.WriteLine("Friday: {0}", WeekDayEnd);
        }
    }

    class MainClass {
        public static void Main(string[] args) {
            EnumClass e = new EnumClass();

            e.enumMethod1();

            Console.ReadLine();
        }
    }
}
