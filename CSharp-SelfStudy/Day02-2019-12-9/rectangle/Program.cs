﻿using System;

namespace RectangleApplication{
    class Rectangle{
        double length;
        double width;
        public void Acceptdetails(double _length, double _width){
            length = _length; 
            width = _width;
        }
        public double GetArea(){
            return length * width;
        }
        public void Display(){
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    class ExecuteRectangle{
        static void Main(string[] args){
            Rectangle r = new Rectangle();
            r.Acceptdetails(4.5, 3.5);
            r.Display();
        }
    }
}

// 此程序学习于 - https://www.runoob.com/csharp/csharp-basic-syntax.html
