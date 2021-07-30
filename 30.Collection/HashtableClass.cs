﻿using System;
using System.Collections;

public class HashtableClass {

    public static void logMethod() {
        Hashtable ht = new Hashtable();


        ht.Add("001", "Zara Ali");
        ht.Add("002", "Abida Rehman");
        ht.Add("003", "Joe Holzner");
        ht.Add("004", "Mausam Benazir Nur");
        ht.Add("005", "M. Amlan");
        ht.Add("006", "M. Arif");
        ht.Add("007", "Ritesh Saikia");

        if (ht.ContainsValue("Nuha Ali")) {
            Console.WriteLine("This student name is already in the list");
        } else {
            ht.Add("008", "Nuha Ali");
        }
        // 获取键的集合 
        ICollection key = ht.Keys;

        foreach (string k in key) {
            Console.WriteLine(k + ": " + ht[k]);
        }
    }
}