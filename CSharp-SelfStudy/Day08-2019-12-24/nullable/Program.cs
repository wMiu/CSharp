using System;

namespace nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# 可空类型 ? 与 ??  
            // ?  : 单问号用于对无法直接赋值为null的数据类型进行null赋值。此时这个数据类型为NullAble
            
            // int? i = 3;
            // Nullable<int> i = new Nullable<int>(3);
            // 以上两种等价

            // int i;  // 默认值为0
            // int? ii;  // 默认值为null
            int? num1 = null;
            bool? boolval = new bool?();
            Console.WriteLine("{0}, {1}, ", num1, boolval);

            // ?? ： 双问号 判断一个变量为null时返回一个指定的值。
            // 合并运算符?? null合并运算符把操作数类型隐式转换为另一个可空或不可空的值类型。
            // num1 = num2 ?? 1; // 如果num2 为 null 则 num1 == 1
            int? num2 = null;
            int? num3 = 1;
            int num4;
            num4 = num2 ?? 0;
            Console.WriteLine("如果为空Num = {0}", num4);
            num4 = num3 ?? 0;
            Console.WriteLine("如果不为空 = {0}", num4);
        }
    }
}
