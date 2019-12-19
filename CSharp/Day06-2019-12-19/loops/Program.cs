using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // 循环 - loops
            /* 
                while 循环 - 只要给定的条件为真就会一直执行。
                while(condition){  // 当 条件为真的时候进入循环 若为假则不执行或退出循环
                    循环的语句块;  // 当运行完毕后会 重新判断条件是否为真。
                }
                * 注意 : 一般情况，为了避免死循环的出现，while的循环体中会对循环条件做出更改。
            */
            Console.WriteLine("--- While ---");
            int w1 = 1;
            while (w1 < 10){
                Console.WriteLine("现在的w1是 {0}", w1);
                 w1++;  // 对a的值做出调整，避免死循环
            }

            /*
                for 循环 - 可以指定循环次数。
                for( init; condition; increment ){
                    循环体;
                }
                执行流程:
                init -> condition -true-> 循环体 -> increment -
                            ^---------------------------------|
            */
            Console.WriteLine("--- For ---");
            for ( int f1 = 1; f1 < 10; f1++){
                Console.WriteLine("f1 = {0}", f1);
            }
            /*
                foreach 循环 - 可以迭代数组或是一个集合对象。
            */
            Console.WriteLine("--- Foreach ---");
            int[] array1 = new int[] {1, 2, 3, 4, 5};
            int index = 0;
            foreach (int i1 in array1){
                Console.WriteLine("array[{0}] = {1}", index, i1);
                index++;
            }
            /*
                do...while 循环 - 至少循环一次。
                do{
                    循环体;
                } while {condition};
                
                循环流程:
                    循环体 -> condition -
                    ^------true------|
            */
            Console.WriteLine("--- Do...While ---");
            int dw1 = 0;
            do{
                Console.WriteLine("dw1 = {0}", dw1);
                dw1++;
            }while (dw1 < 0);

            /*
                循环嵌套
            */
            Console.WriteLine("--- 质数 ---");
            // smallProject - 100以内的质数
            int i, j;
            for ( i = 2; i < 100; i++){
                for ( j = 2; j <= i / j; j++){
                    if (i % j == 0){
                        break;
                    }
                }
                if (j > (i / j)){
                    Console.WriteLine("质数 - {0}", i);
                }
            }
        }
    }
}
;