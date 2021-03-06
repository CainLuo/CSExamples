using System;
using System.Collections.Generic;

delegate T NumberChanger<T>(T n);

class GenericDelegate {
    static int num = 10;
    public static int AddNum(int p) {
        num += p;
        return num;
    }

    public static int MultNum(int q) {
        num *= q;
        return num;
    }
    public static int getNum() {
        return num;
    }

    public static void logMethod() {
        // 创建委托实例
        NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
        NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);
        // 使用委托对象调用方法
        nc1(25);
        Console.WriteLine("Value of Num: {0}", getNum());
        nc2(5);
        Console.WriteLine("Value of Num: {0}", getNum());
    }
}