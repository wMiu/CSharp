using System;

namespace judge
{
    class Program
    {
        static void Main(string[] args)
        {
            // if 语句
            /*
                if (boolean_expression){
                    如果boolean_expression为真则执行语句块
                }
            */
            int a = 1;  // 局部变量 - 只有在此作用域下才能使用
            Console.WriteLine("a = {0}", a);
            if (a == 1) {
                Console.WriteLine("a 等于 1");
            }  

            // if else 语句
            /*
                if (boolean_expression){
                    如果 布尔表达式为为真则执行此处代码块
                } else {
                    如果为假则执行此处代码块
                }
            */       
            if (a == 2) {
                Console.WriteLine("a 等于 2");
            } else {
                Console.WriteLine("a 不等于 2");
            }
            // if ... else if ... else 语句
            /*
                if (boolean_expression1){
                    如果布尔表达式1 为真则执行此处代码块
                } else if (boolean_expression2){
                    如果布尔表达式2 为真则执行此处代码块
                } ... {
                    ...
                } else {
                    以上表达式全为假则执行此处代码块
                }
            */
            if (a == 2){
                Console.WriteLine("a 等于 2");
            } else if (a == 3){
                Console.WriteLine("a 等于 3");
            } else {
                Console.WriteLine("a 不等于 2 ，也不等于 3");
            }
            // 注意 - 一个if...else if...else 语句最多且只有一个else,并且出现在最后
            //      - 在上面的条件成立后将不会执行下面的其他条件了。
        }
    }
}
