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

            // 嵌套 if - 不建议嵌套超过三层
            int b = 2;
            if (a == 1){
                if (b == 2){
                    Console.WriteLine("a 等于 1，b 等于 2");
                }
            }

            
            // switch 语句
            /*
                switch (expression){
                    case constant-expression:
                        statement(s);
                        break;  // 终止
                    case constant-exoression:
                        statement(s);
                        break;
                    ...
                    default:
                        statement(s);
                        break;
                }
                1. switch 中的expression 必须是一个整型或枚举类型，或者为一个class类型，
                   其中class有一个单一的转换函数将转换为整型或枚举类型
                2. 可以有多个 case， 但至多只能右一个 default 且只能出现在最后
                3. C# 中 只有当case为空时可以不写 break。
                4. 无法向下贯穿执行，可以使用 goto
            */
            int a1 = 1;
            switch (a1) {
                case 0:
                    Console.WriteLine("a1 = {0}", a1);
                    break;
                case 1:
                    Console.WriteLine("a1 = {0}", a1);
                    break;
                default:
                    Console.WriteLine("其他");
                    break;
            }
            // 嵌套 switch 语句
            int a2= 2;
            switch (a1){
                case 1:
                    switch(a2){
                        case 2:
                            Console.WriteLine("a1 = {0}, a2 = {1}", a1, a2);
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("其他");
                    break;
            }
        }
    }
}
