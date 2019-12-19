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
        }
    }
}
