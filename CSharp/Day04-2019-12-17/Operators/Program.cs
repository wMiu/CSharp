using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // 算数运算符
            /*
            * + 将左右两个值加起来
            * - 左边的值 减去 右边的值
            * * 左右两个值相乘
            * / 左边的值 除以 右边的值
            * % 取余 左除右余几
            * ++ 自增运算符 自增一
            * -- 自减运算符 自减一
            */
            int a = 10;
            int b = 3;
            Console.WriteLine("a % b = {0}", a % b);

            // 自增 ： a++ 与 ++a
            // a++ : 先赋值后自增
            // ++a : 先自增在赋值
            int c;
            a = 1;  // 初始化a
            c = a++;
            Console.WriteLine("a = {0}, c = {1}", a, c);
            a = 1;
            c = ++a;
            Console.WriteLine("a = {0}, c = {1}", a, c);
            a = 1;
            c = a--;
            Console.WriteLine("a = {0}, c = {1}", a, c);
            a = 1;
            c = --a;
            Console.WriteLine("a = {0}, c = {1}", a, c);
        }
    }
}
