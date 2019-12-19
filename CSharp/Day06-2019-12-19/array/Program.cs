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
            double[] number = new double[10];
            // 赋值给数组
            number[0] = 0.1;
            // number[11] = 11.1;  // 超出边界。 ERROR : Index was outside the bounds of the array
            Console.WriteLine(number[0]);
            // 声明的时候赋值。
            int[] arrI1 = {1 ,2, 3};
            Console.WriteLine(arrI1[2]);
            // 初始化后赋值。
            int[] arrI2 = new int[2] {0, 1};
            Console.WriteLine(arrI2[1]);
            // 初始化后赋值，可以忽略数组大小。
            int[] arrI3 = new int[] {1};
            Console.WriteLine(arrI3[0]);
            // 可以将一个Array 赋值给另一个变量中，浅拷贝。
            int[] arrI4 = arrI3;
            Console.WriteLine(arrI4[0]);

            /*
                当创建一个数组时，C# 编译器会根据数组类型隐式初始化每一个
                数组元素为一个默认值。如 int[] 所有元素的默认值都为0。
            */
            // 访问数组元素
            int a1 = arrI4[0];
            Console.WriteLine("a1 = {0}", a1);
            
            // for 循环 访问数组的每一元素。
            for ( int i = 0; i < arrI1.Length; i++){
                Console.WriteLine("arrI1的第{0}个元素的值是{1}。", i, arrI1[i]);
            }
            Console.WriteLine("--- ForEach ---");
            // 使用 foreach 循环
            int index = 0;
            foreach ( int item in arrI1){
                Console.WriteLine("arrI1的第{0}个元素的值是{1}。", index, item);
                index++;
            }
        }
    }
}
