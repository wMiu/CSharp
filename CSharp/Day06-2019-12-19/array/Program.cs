using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            // 数组 Array
            /*
            *   数组是一个存储相同类型元素且有固定大小的顺序集合。
            *   通常认为数组是一个同一类型变量的集合。
            *   声明数组 
            *            - datatype[] arrayName;
            *            - datatype : 数组的类型。
            *            - []       : 数组的秩(维度)。
            *            - arratName: 数组的名字。
            */
            // double[] number;  // 声明数组
            // 初始化数组。
            double[] number = new int[10];
            number[0] = 1.1;
            Console.WriteLine(number[0]);
        }
    }
}
