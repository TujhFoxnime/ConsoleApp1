using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Figure
    {
        private Point[] points;

        public Figure(Point a, Point b, Point c)
        {
            points = new Point[3];
            points[0] = a;
            points[1] = b;
            points[2] = c;
        }

        public Figure(Point a, Point b, Point c, Point d)
        {
            points = new Point[4];
            points[0] = a;
            points[1] = b;
            points[2] = c;
            points[3] = d;
        }

        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            points = new Point[5];
            points[0] = a;
            points[1] = b;
            points[2] = c;
            points[3] = d;
            points[4] = e;
        }
        /// строковое автосвойство для хранения названия фигуры
        public string Name { get; set; }
        /// самые первые скобки - длина по координате, вторые - возводим в квадрат, третьи - квадратный корень из суммы квадратов
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
        }

        public double PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }
            perimeter += LengthSide(points[0], points[points.Length - 1]);

            return perimeter;
        }
    }
}
