using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Минимальные и максимальные значения для предопределенных типов данных CTS.");
            Console.WriteLine($"sbyte: Минимальное значение = {sbyte.MinValue}, Максимальное значение = {sbyte.MaxValue}");
            Console.WriteLine($"byte: Минимальное значение = {byte.MinValue}, Максимальное значение = {byte.MaxValue}");
            Console.WriteLine($"short: Минимальное значение = {short.MinValue}, Максимальное значение = {short.MaxValue}");
            Console.WriteLine($"ushort: Минимальное значение = {ushort.MinValue}, Максимальное значение = {ushort.MaxValue}");
            Console.WriteLine($"int: Минимальное значение = {int.MinValue}, Максимальное значение = {int.MaxValue}");
            Console.WriteLine($"uint: Минимальное значение = {uint.MinValue}, Максимальное значение = {uint.MaxValue}");
            Console.WriteLine($"long: Минимальное значение = {long.MinValue}, Максимальное значение = {long.MaxValue}");
            Console.WriteLine($"ulong: Минимальное значение = {ulong.MinValue}, Максимальное значение = {ulong.MaxValue}");
            Console.WriteLine($"double: Минимальное значение = {double.MinValue}, Максимальное значение = {double.MaxValue}");
            Console.WriteLine($"decimal: Минимальное значение = {decimal.MinValue}, Максимальное значение = {decimal.MaxValue}");

            //2
            Console.WriteLine("Введите первую сторону:");
            double _side1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите вторую сторону:");
            double _side2 = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(_side1, _side2);

            Console.WriteLine("Периметр прямоугольника: " + rectangle.Perimeter);
            Console.WriteLine("Площадь прямоугольника: " + rectangle.Area);

            //3

            Point point1 = new Point(0, 5);
            Point point2 = new Point(0, 4);
            Point point3 = new Point(3, 0);
            Point point4 = new Point(3, 9);
            Figure quadrangular = new Figure(point1, point2, point3, point4);
            quadrangular.Name = "Четырёхугольник";
            quadrangular.PerimeterCalculator();

            Console.WriteLine("Название фигуры: " + quadrangular.Name);
            Console.WriteLine("Периметр фигуры: " + quadrangular.PerimeterCalculator());

            Console.ReadLine();
        }
    }
}
