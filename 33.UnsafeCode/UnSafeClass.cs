using System;

class UnsafeCodeClass {
    public static unsafe void logMethod() {
        int var = 20;
        int* p = &var;
        Console.WriteLine("Data is: {0} ", var);
        Console.WriteLine("Address is: {0}", (int)p);
    }

    public static void logMethod2() {
        unsafe {
            int var = 20;
            int* p = &var;
            Console.WriteLine("Data is: {0} ", var);
            Console.WriteLine("Data is: {0} ", p->ToString());
            Console.WriteLine("Address is: {0} ", (int)p);
        }
    }
}

class TestPointer {
    public unsafe void swap(int* p, int* q) {
        int temp = *p;
        *p = *q;
        *q = temp;
    }

    public unsafe static void logMethod() {
        TestPointer p = new TestPointer();
        int var1 = 10;
        int var2 = 20;
        int* x = &var1;
        int* y = &var2;

        Console.WriteLine("Before Swap: var1:{0}, var2: {1}", var1, var2);
        p.swap(x, y);

        Console.WriteLine("After Swap: var1:{0}, var2: {1}", var1, var2);
    }

    public unsafe static void logMethod2() {
        int[] list = { 10, 100, 200 };
        fixed (int* ptr = list)

            /* 显示指针中数组地址 */
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("Address of list[{0}]={1}", i, (int)(ptr + i));
                Console.WriteLine("Value of list[{0}]={1}", i, *(ptr + i));
            }
    }
}