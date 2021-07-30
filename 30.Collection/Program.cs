using System;
using System.Collections;

namespace Collection {
    class MainClass {
        public static void Main(string[] args) {
            ArrayListClass.logMethod();
            Console.WriteLine();

            HashtableClass.logMethod();
            Console.WriteLine();

            SortedListClass.logMethod();
            Console.WriteLine();

            StackClass.logMethod();
            Console.WriteLine("\n");

            QueueClass.logMethod();
            Console.WriteLine();

            BitArrayClass.logMethod();

            Console.ReadLine();
        }
    }
}

/*
 * 动态数组（ArrayList）：https://www.w3cschool.cn/csharp/csharp-arraylist.html
 * 它代表了可被单独索引的对象的有序集合。
 * 它基本上可以替代一个数组。但是，与数组不同的是，您可以使用索引在指定的位置添加和移除项目，动态数组会自动重新调整它的大小。它也允许在列表中进行动态内存分配、增加、搜索、排序各项。
 * 
 * 
 * 哈希表（Hashtable）：https://www.w3cschool.cn/csharp/csharp-hashtable.html
 * 它使用键来访问集合中的元素。
 * 当您使用键访问元素时，则使用哈希表，而且您可以识别一个有用的键值。哈希表中的每一项都有一个键/值对。键用于访问集合中的项目。
 * 
 * 
 * 排序列表（SortedList） ：https://www.w3cschool.cn/csharp/csharp-sortedlist.html
 * 它可以使用键和索引来访问列表中的项。
 * 排序列表是数组和哈希表的组合。它包含一个可使用键或索引访问各项的列表。如果您使用索引访问各项，则它是一个动态数组（ArrayList），如果您使用键访问各项，则它是一个哈希表（Hashtable）。集合中的各项总是按键值排序。
 * 
 * 
 * 堆栈（Stack）：https://www.w3cschool.cn/csharp/csharp-stack.html
 * 它代表了一个后进先出的对象集合。
 * 当您需要对各项进行后进先出的访问时，则使用堆栈。当您在列表中添加一项，称为推入元素，当您从列表中移除一项时，称为弹出元素。
 * 
 * 
 * 队列（Queue）：https://www.w3cschool.cn/csharp/csharp-queue.html
 * 它代表了一个先进先出的对象集合。
 * 当您需要对各项进行先进先出的访问时，则使用队列。当您在列表中添加一项，称为入队，当您从列表中移除一项时，称为出队。
 * 
 * 
 * 点阵列（BitArray）：https://www.w3cschool.cn/csharp/csharp-bitarray.html
 * 它代表了一个使用值 1 和 0 来表示的二进制数组。
 * 当您需要存储位，但是事先不知道位数时，则使用点阵列。您可以使用整型索引从点阵列集合中访问各项，索引从零开始。
 */