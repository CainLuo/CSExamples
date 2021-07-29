using System;

namespace String {

    class StringClass {

        public void stringMethod1() {
            //字符串，字符串连接
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";

            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);

            //通过使用 string 构造函数
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            //方法返回字符串
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            string message = string.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            //用于转化值的格式化方法
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = string.Format("Message sent at {0:t} on {0:D}",
            waiting);
            Console.WriteLine("Message: {0}\n", chat);
        }

        // 对比两个字符串
        public void stringMethod2() {
            string str1 = "This is test";
            string str2 = "This is text";

            if (string.Compare(str1, str2) == 0) {
                Console.WriteLine(str1 + " and " + str2 + " are equal.\n");
            } else {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.\n");
            }
        }

        // 是否包含某个字符串
        public void stringMethod3() {
            string str = "This is test";
            if (str.Contains("test")) {
                Console.WriteLine("The sequence 'test' was found.\n");
            }
        }

        // 获取子字符串
        public void stringMethod4() {
            string str = "Last night I dreamt of San Pedro";
            Console.WriteLine(str);

            string subStr = str.Substring(11);
            Console.WriteLine(subStr);
        }

        // 连接字符串
        public void stringMethod5() {
            string[] starray = new string[]{
                "Down the way nights are dark",
                "And the sun shines daily on the mountain top",
                "I took a trip on a sailing ship",
                "And when I reached Jamaica",
                "I made a stop"
            };

            string str = string.Join("\n", starray);
            Console.WriteLine(str);
        }
    }

    class MainClass {
        public static void Main(string[] args) {
            StringClass str = new StringClass();
            str.stringMethod1();

            str.stringMethod2();

            str.stringMethod3();

            str.stringMethod4();

            str.stringMethod5();

            Console.ReadLine();
        }
    }
}
