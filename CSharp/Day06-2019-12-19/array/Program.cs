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

            // 多维数组
            Console.WriteLine("多维数组");
            // 声明二维数组
            int [,] twoArr1 = new int[1,1] {
                {1}
            };
            Console.WriteLine(twoArr1[0,0]);
            // 三维数组
            int [, ,] threeArr1 = new int [1,1,1] {
                {
                    {2}
                }
            };
            Console.WriteLine(threeArr1[0,0,0]);
            // 循环显示二维数组的每一个元素 与 位置。
            int [,] twoArr2 = new int[3,3] {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            // Console.WriteLine(twoArr2[0].Length);
            foreach (int twoArr2Item in twoArr2){
                Console.WriteLine(twoArr2Item);
            }
            Console.WriteLine("--- For ---");
            // int rank = twoArr2.Rank;
            // int[] dArray = new int[] {};
            // for (int tArI = 0; tArI < twoArr2.Rank; tArI++){
            //     Console.WriteLine(tArI);
            //     dArray[tArI] = twoArr2.GetLength(tArI);
            // }
            // 强行遍历
            for (int tArrI = 0; tArrI < 3; tArrI++){
                for (int tArrJ = 0; tArrJ < 3;tArrJ++){
                    Console.WriteLine("twoArr2[{0},{1}] = {2}", tArrI, tArrJ, twoArr2[tArrI, tArrJ]);
                }
            }
            // 交错数组 - 数组的数组
            Console.WriteLine("交错数组");
            // 声明
            int [][] interlaceArray = new int[3][] {
                new int[]{1, 2, 3},
                new int[]{4, 5, 6},
                new int[]{7, 8, 9}
            };
            Console.WriteLine(interlaceArray.Length);
            // 遍历
            for (int iArrI = 0; iArrI < interlaceArray.Length; iArrI++){
                for (int iArrJ = 0; iArrJ < interlaceArray[iArrI].Length; iArrJ++){
                    Console.WriteLine("interlaceArray[{0}][{1}] = {2}", iArrI, iArrJ, interlaceArray[iArrI][iArrJ]);
                }
            }

            // Array 类的属性。
            int[] arrAttribute = new int[] {1, 2, 3, 4, 5};
            // ISFixedSize - 返回一个Boolean，表示该数组是否带有固定的大小
            bool isFixedSize = arrAttribute.IsFixedSize;
            Console.WriteLine("数组是否有固定大小 - {0}", isFixedSize);
            // IsReadOnly - 返回一个Boolean, 表示该数组是否可读
            bool isReadOnly = arrAttribute.IsReadOnly;
            Console.WriteLine("数组是否可读 - {0}", isReadOnly);
            // Length - 返回32 位整数， 表示该数组的所有维度元素总和
            int len = arrAttribute.Length;
            Console.WriteLine("数组的总元素为Length - {0}", len);
            // LongLenth - 返回64 位整数，表示该数组的所有维度元素总和
            long longlen = arrAttribute.LongLength;
            Console.WriteLine("数组的总元素为LongLength - {0}",longlen);
            // Rank - 获取数组的秩(维度)
            int rank = arrAttribute.Rank;
            Console.WriteLine("数组的维度为 - {0}", rank);

            // 数组类的方法
            int[] arrFunction = new int[] {1, 2, 3};
            Console.WriteLine("ArrFunction - {0}", arrFunction);
            // Clear - 根据元素的类型，设置数组中某个范围的元素为零。
            // Copy(Arr1, Arr2, Int32) - 从arr1第一个元素开始复制一个范围到arr2第一个元素的位置。范围由int32指定。
            // CopyTo(Array, Int32)
            // GetLength - 返回32 位整数， 表示该数组的所有维度元素总和
            // GetLongLenth - 返回64 位整数，表示该数组的所有维度元素总和
            // GetLowerBound
            // GetType
            // GetUpperBound
            // GetValue(Int32)
            // IndexOf(Array, Object)
            // Reverse(Array)
            // SetValue(Object, Int32)
            // Sort(Array)  - 对数组排序
            // ToString
            
            Array.Sort(arrFunction);
            Console.WriteLine("排序后的 ArrFunction - {0}", arrFunction);

        }
    }
}