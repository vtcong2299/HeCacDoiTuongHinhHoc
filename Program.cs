using System;

namespace HeCacDoiTuongHinhHoc
{
    class Program
    {
        static void Main(string[] args)

        {

            Shape shape = new Shape();

            Console.WriteLine(shape);

            shape = new Shape("red", false);

            Console.WriteLine(shape);

            Console.WriteLine("Hello World!");

            // Circle test

            Circle circle = new Circle();

            Console.WriteLine(circle);

            circle = new Circle(3.5);

            Console.WriteLine(circle);

            circle = new Circle(3.5, "indigo", false);

            Console.WriteLine(circle);

            // Rectangle test

            Rectangle rectangle = new Rectangle();

            Console.WriteLine(rectangle);

            rectangle = new Rectangle(3.5,5.5);

            Console.WriteLine(rectangle);

            rectangle = new Rectangle(3.5,5.5, "blue", false);

            Console.WriteLine(rectangle);

            // Square test

            Square square = new Square();

            Console.WriteLine(square);

            square = new Square(5);

            Console.WriteLine(square);

            square = new Square(5, "blue", false);

            Console.WriteLine(square);

        }
    }
}