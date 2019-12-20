using System;

namespace func
{
    class Program
    {
        static void Main(string[] args)
        {
            // function 函数
            /*
                定义函数
                    <Access Specifier> <Return Type> <Method Name>(Parameter List){
                        Method Body
                    }
                    - Access Specifier : 访问修饰符，决定了变量或方法对另一个类是否可见。
                    - Return type      : 返回类型，若方法没有返回值，则写 void
                    - Method name      : 方法名称，唯一标识符。
                    - Parameter list   : 参数列表，可以为空。
                    - Method body      : 方法主体
            */
            
            // 实例化
            Program p = new Program();
            int num1 = 10;
            int num2 = 20;
            // 调用函数
            int result = p.findMax(num1, num2);
            Console.WriteLine(result);

            // 调用递归函数 求阶乘
            Console.WriteLine("5的阶乘 = {0}", p.factorail(5));

            // 参数传递
            // 值传参 - 赋值实际参数给函数的形式参数，形参改变不会改变实参。
            // 引用参数 - 这种方法赋值参数的内存位置给形参，意味着，形参改变实参也会改变。
            Console.WriteLine("--- 引用传递参数 ---");
            int x = 1;
            int y = 2;
            p.addNumber(ref x, ref y);  // 使用引用传参必须要将ref 一并传递。
            Console.WriteLine(x);
            Console.WriteLine(y);
            // 输出参数 - 可以返回多个值
            Console.WriteLine("--- 输出传递参数 ---");
            p.getValues(out int x2, out int y2);  // 只需要声明，在函数内部赋值。
            Console.WriteLine(x2);
            Console.WriteLine(y2);


            
        }
        // 定义函数 FindMax 
        public int findMax(int num1, int num2){
            if (num1 > num2){
                return num1;
            }
            return num2;
        }

        // 递归 - 函数自身调用。需要结束条件。
        public int factorail(int number){
            if (number == 1){
                return 1;
            }
            return factorail(number - 1) * number;
        }

        // 引用传参
        public void addNumber(ref int x, ref int y){
            x += 1;
            y += 2;
        }
        
        // 输出传参
        public void getValues(out int x2, out int y2){
            x2 = 10;
            y2 = 10;
        }
    }
}
