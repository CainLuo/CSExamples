﻿using System;
using System.Collections;

public class QueueClass {
    public static void logMethod() {
        Queue q = new Queue();

        q.Enqueue('A');
        q.Enqueue('M');
        q.Enqueue('G');
        q.Enqueue('W');

        Console.WriteLine("Current queue: ");

        foreach (char c in q) {
            Console.Write(c + " ");
        }

        Console.WriteLine();

        q.Enqueue('V');
        q.Enqueue('H');

        Console.WriteLine("Current queue: ");

        foreach (char c in q) {
            Console.Write(c + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Removing some values ");

        char ch = (char)q.Dequeue();
        Console.WriteLine("The removed value: {0}", ch);

        ch = (char)q.Dequeue();
        Console.WriteLine("The removed value: {0}", ch);
    }
}