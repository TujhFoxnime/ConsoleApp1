using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodRectangle()
        {
            Rectangle _rectangle = new Rectangle(5, 4); // ввод сторон для Rectangle
            ////////////
            Console.WriteLine("Проверка значения площади...");
            double expected_res_A = 20; //4*5
            double actual_res_A = _rectangle.Area;

            Console.WriteLine("Ожидаемое значение площади: " + expected_res_A);
            Console.WriteLine("Полученное значение: " + actual_res_A);

            Assert.AreEqual(expected_res_A, actual_res_A, "Ошибка! Значение программы не совпадает с ожидаемым.");
            //////////////////
            Console.WriteLine("Проверка значения периметра...");
            double expected_res_P = 18; //(4+5)*2=18
            double actual_res_P = _rectangle.Perimeter;

            Console.WriteLine("Ожидаемое значение периметра: " + expected_res_P);
            Console.WriteLine("Полученное значение: " + actual_res_P);


            Assert.AreEqual(expected_res_P, actual_res_P, "Ошибка! Значение программы не совпадает с ожидаемым.");
        }
        [TestMethod]
        public void TestPerimeterCalculator()
        {
            // Создаем точки
            Point a = new Point(0, 0);
            Point b = new Point(0, 5);
            Point c = new Point(5, 5);
            Point d = new Point(5, 0);

            // Создаем фигуру
            Figure square = new Figure(a, b, c, d);
            square.Name = "Квадрат";

            // Проверяем периметр
            Assert.AreEqual(20, square.PerimeterCalculator());

            // Создаем еще точки
            Point e = new Point(3, 8);
            Point f = new Point(8, 8);
            Point g = new Point(10, 5);

            // Создаем другую фигуру
            Figure triangle = new Figure(e, f, g);
            triangle.Name = "Треугольник";

            // Проверяем периметр
            Assert.AreEqual(16.22, triangle.PerimeterCalculator(), 0.01);
        }
    }
}
