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

            // 关系运算符
            /*
            * == 等于
            * != 不等于
            * >  大于
            * <  小于
            * >= 大于等于
            * <= 小于等于
            */

            // 逻辑运算符
            /*
            * && 逻辑与， 左右两边都为零， 则为true - 一假俱假
            * || 逻辑或， 左右两边人任意一边非零， 则为true - 一真俱真
            * !  逻辑非， 取反， 条件为真，则为假；条件为假则为真。
            */
            bool b1 = true;
            bool b2 = true;
            bool b3 = false;
            bool b4 = false;
            // 逻辑与 &&
            Console.WriteLine("逻辑与: 都为真-{0}, 左真-{1}, 右真-{2}, 都为假-{3}", b1 && b2, b1 && b3, b3 && b1, b3 && b4);
            // 逻辑或 ||
            Console.WriteLine("逻辑或: 都为真-{0}, 左真-{1}, 右真-{2}, 都为假-{3}", b1 || b2, b1 || b3, b3 || b1, b3 && b4);
            // 逻辑非 !
            Console.WriteLine("逻辑非: 真-{0}， 假-{1}", !b1, !b3);
        }
    }
}
