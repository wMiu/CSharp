using System;

namespace VariableAndConstant
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable 变量
            // 定义 <data_type> <variable_list>; - data_type为有效的C#数据类型
            int i, j;  // 定义
            i = 1;
            j = 2;
            char c;
            c = 'c'; // 赋值
            // 变量初始化 - <data_type> <variable_name> = value;
            string str = "string";  // 定义并赋值

            string u = Console.ReadLine();  // 等待用户输入并将输入存在变量中
            // public static string ReadLine ();  - 返回 String
            // 文档 https://docs.microsoft.com/zh-cn/dotnet/api/system.console.readline?view=netframework-4.8
            Console.WriteLine("i: {0}, j: {1}, c: {2}, str: {3}, u: {4}", i, j, c, str, u);

            // Constant(const) 常量
            /*
            * 常量是固定的值，在程序执行期间不可变。
            * 常量可以是任何基本数据类型。
            */
            const int c0 = 1;
            // c0 = 2;  // 报错。常量不可以重新赋值。  Error:  赋值号左边必须是变量、属性或索引器
            Console.WriteLine(c0);
        }
    }
}
