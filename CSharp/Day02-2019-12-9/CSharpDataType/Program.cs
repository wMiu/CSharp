﻿using System;

namespace CSharpDataType
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            * bool 布尔值
            * byte 0 ~ 255 整数 | sbyte -128 ~ 127
            * char Unicode 字符
            * float 单精度浮点数
            * double 双精度浮点数
            * decimal 高精度浮点数
            * int 32位整数 | uint 32位正整数
            * long 大整数64位 | ulong 64位正整数
            * short 16位整数 | ushort 0 ~ 65535 整数
            */

            // 类型转换 与 C# 的数据类型
            double a = 1.111;
            int b;
            b = (int)a;
            Console.WriteLine("Double 转换为 Int : {0}", b);
            // -> 1 ; 显性数据类型转换，浮点型转换为整型只取整数部分，可能会造成数据丢失。
            bool c = true;
            bool d = false;
            Console.WriteLine("Bool - True: {0}, False: {1}", c, d); // -> True, False
            // Bool 转换为 Int
            // int e = (int)c; | Error: 无法将 Bool 转换为 Int
            double e = Convert.ToDouble(d);
            int f = Convert.ToInt32(c);
            Console.WriteLine("Bool 转换为 Int， Ture = {0}; Bool 转换为 Double， Fales = {1}", e, f);
            // -> 0, 1 | 将Bool类型转换为Double还是 0 / 1

            // sizeof(type) : 返回给定类型的变量所占用的字节数
            // 官方文档 : https://docs.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/sizeof
            Console.WriteLine("int sizeof : {0}", sizeof(int));  // -> 4
            Console.WriteLine("double sizeof : {0}", sizeof(double));  // -> 8
            Console.WriteLine("bool sizeof : {0}", sizeof(bool));  // -> 1
            
            //Object Type - 对象类型
            object obj;
            // 装箱 - 将一个值类型隐式转换为对象类型称之为装箱。
            int i = 1;
            obj = i;
            obj = (object)i;
            // 拆箱 - 将一个对象类型转换为值类型称之为拆箱。
            int j = (int)obj;
        }
    }
}
