using ConsoleApp1;

namespace TestSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cirlce = new Circle(5);
            cirlce.Print();
            var triangle = new Triangle(new double[] { 3, 4, 5 });
            bool b =Triangle.isPryamougolniy(triangle);
            if (b) Console.WriteLine("Треугольник прямоугольный");
            triangle.Print();
            Console.ReadLine();
        }
    }
}