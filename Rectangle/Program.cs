using System;

namespace rectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nhap chieu rong:");
            double width = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu cao:");
            double height = Double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine("Hinh chu nhat cua ban \n" + rectangle.Display());
            Console.WriteLine("Chu vi hinh chu nhat: " + rectangle.GetPerimeter());
            Console.WriteLine("Dien tich hinh chu nhat: " + rectangle.GetArea());
            Console.ReadKey();
        }

    }

    public class Rectangle
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

        public double GetArea()
        {
            return this.width * this.height;
        }

        public double GetPerimeter()
        {
            return (this.width + this.height) * 2;
        }

        public String Display()
        {
            return "Hinh chu nhat{" + "Rong =" + width + ", Cao =" + height + "}";
        }
        
    }
}