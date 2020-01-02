using System;

namespace CSharpTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * 类型转换
            *   隐式类型转换 ： C#中默认的转换方式，不会造成数据丢失
            *   显示类型转换 ： 即为强制类型转换，会造成数据丢失。
            */
            double d0 = 3.14;
            int i0 = (int)d0;  // 强制类型转换
            Console.WriteLine(i0);  // -> 3

            // C# 的 内置数据类型转换函数
            int i = 1;
            // ToBoolean : 将类型转换为布尔型
            Console.WriteLine(Convert.ToBoolean(i));
            // ToByte : 将类型转换为字节类型
            Console.WriteLine(Convert.ToByte(i));
            // ToChar : 将类型转换为Unicode字符类型
            Console.WriteLine(Convert.ToChar(i));
            // ToDateTime : 将类型转换为日期时间类型i
            // Int32 j = 20191216;
            // Console.WriteLine(Convert.ToDateTime(j));

            // ToDecimal : 把类型转换为双精度浮点型
            Console.WriteLine(Convert.ToDouble(i));
            // ToInt[16,32,64] : 将类型转换为整数类型
            Console.WriteLine(Convert.ToInt16(i));
            Console.WriteLine(Convert.ToInt32(i));
            Console.WriteLine(Convert.ToInt64(i));
            
            // To Sbyte : 将类型转换为有符号字节类型
            // Console.WriteLine(Convert.ToSbyte(i));
            // To Single :
            // To String : 
            // To Type : 

            // ToUInt[16,32,64] : 将类型转换为无符号整数类型
            Console.WriteLine(Convert.ToUInt16(i));
            Console.WriteLine(Convert.ToUInt32(i));
            Console.WriteLine(Convert.ToUInt64(i));
        }
    }
}
