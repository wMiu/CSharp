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

            // 位运算符 - 难点
            // 作用于位，对逐位进行操作。
            /*
            * &  按位与    - 都为 1 则是 1 
            * |  按位或    - 有一个是 1 则是 1
            * ^  按位异或  - 一个 1 一个 0， 则是 1
            * ~  取反      - 1 变 0， 0 变 1
            * << 左移      - 向左移动一位
            * >> 右移      - 向右移动一位
            */
            int i1 = 6;   // 0000 0110
            int i2 = 19;  // 0001 0011
            // & 按位与
            Console.WriteLine("6 % 19 = {0}", i1 & i2);  // 0000 0010
            // | 按位或
            Console.WriteLine("6 | 19 = {0}", i1 | i2);  // 0001 0111
            // ^ 按位异或
            Console.WriteLine("6 ^ 19 = {0}", i1 ^ i2);  // 0001 0101
            // ~ 取反
            Console.WriteLine("~6 = {0}", ~i1);  // 1111 1001
            // << 左移
            Console.WriteLine("6 << 1 = {0}", i1 << 1);  // 0000 1100
            // >> 右移
            Console.WriteLine("6 >> 1 = {0}", i1 >> 1);  // 0000 0011

            // 赋值运算符
            /*
            * =   将右边的值赋值给左边
            * +=  将右边的值加去左边的值后赋值给左边 l = l + r == l += r
            * -=  l -= r == l = l - r
            * *=  l *= r == l = l * r
            * /=  l /= r == l = l / r
            * %=  l %= r == l = l % r
            * <<= l <<= r == l = l << r
            * >>= l <<= r == l = l << r
            * &=  l &= r == l = l & r
            * ^=  l ^= r == l = l ^ r
            * |=  l |= r == l = l | r
            */

            // 其他运算符
            /*
            * sizeof() - 返回数据类型大小。
            * typeof() - 返回class的类型。
            * &        - 返回变量的地址。  &v;
            * *        - 变量的指针。      *v;
            * ?:       - 条件表达式(三目)  a == b ? true : false
            * is       - 判断对象是否为同一个类型。
            * as       - 强制转换，失败也不会抛出异常。
            */
            int s1 = 1;
            bool s2 = s1 == 1 ? true : false;
            Console.WriteLine("s1是否等于1 : {0}", s2);
        }
    }
}
