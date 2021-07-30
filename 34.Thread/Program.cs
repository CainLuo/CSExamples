using System;
using System.Threading;

// 多线程解释：https://www.w3cschool.cn/csharp/csharp-multithreading.html
namespace ThreadApplication {

    // 创建子线程
    class ThreadCreationProGram {
        public static void callToChildThread() {
            Console.WriteLine("Child thread starts");
        }

        public static void startThread() {
            ThreadStart childref = new ThreadStart(callToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
        }
    }

    // 管理线程
    class ThreadManager {
        private static void callToChildThread() {
            Console.WriteLine("Child thread starts");
            // 线程暂停 5000 毫秒
            int sleepfor = 5000;
            Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");
        }

        public static void startThread() {
            ThreadStart childref = new ThreadStart(callToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
        }
    }

    class DeintThread {
        static void callToChildThread() {
            try {
                Console.WriteLine("Child thread starts");
                // 计数到 10
                for (int counter = 0; counter <= 10; counter++) {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }
                Console.WriteLine("Child Thread Completed");
            } catch (ThreadAbortException e) {
                Console.WriteLine("Thread Abort Exception");
            } finally {
                Console.WriteLine("Couldn't catch the Thread Exception");
            }
        }

        public static void startThread() {
            ThreadStart childref = new ThreadStart(callToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
            // 停止主线程一段时间
            Thread.Sleep(2000);             // 现在中止子线程
            Console.WriteLine("In Main: Aborting the Child thread");
            childThread.Abort();
        }
    }

    class MainClass {
        public static void Main(string[] args) {
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";

            Console.WriteLine("This is {0}", th.Name);
            Console.WriteLine();

            ThreadCreationProGram.startThread();
            Console.WriteLine();

            ThreadManager.startThread();
            Console.ReadLine();

            DeintThread.startThread();

            Console.ReadLine();
        }
    }
}
