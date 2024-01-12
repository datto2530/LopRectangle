using System;
using System.Drawing;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chieu rong hinh chu nhat");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu cao hinh chu nhat");
            double height = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, height);
            rectangle.PrintfArea();
            rectangle.PrintPerimeter();
        }
    }
    class Rectangle
    {
        double width, height;
        public Rectangle()
        {

        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public void PrintfArea()
        {
            Console.WriteLine("Dien tich la: " + this.width * this.height);
        }
        public void PrintPerimeter()
        {
            Console.WriteLine("Chu vi la: " + (this.width + this.height) * 2);
        }
    }
}