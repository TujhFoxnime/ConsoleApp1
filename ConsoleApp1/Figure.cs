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
        public Figure()
        {
            points = new Point[5];
        }
        public Figure(Point a, Point b, Point c) : this()
        {
            points[0] = a;
            points[1] = b;
            points[2] = c;
        }

        public Figure(Point a, Point b, Point c, Point d) : this(a,b,c) 
        {
            points[3] = d;
        }

        public Figure(Point a, Point b, Point c, Point d, Point e) : this(a,b,c,d)
        {
            points[4] = e;
        }
        /// строковое автосвойство для хранения названия фигуры
        public string Name { get; set; }
        /// самые первые скобки - длина по координате, вторые - возводим в квадрат, третьи - квадратный корень из суммы квадратов
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(A.X - B.X), 2) + Math.Pow(Math.Abs(A.Y - B.Y), 2));
        }

        public double PerimeterCalculator()
        {
            double perimeter = 0;
            int last = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                if (points[i] != null && points[i + 1] == null) { last = i; break; }
                perimeter += LengthSide(points[0], points[i + 1]);
            }
            perimeter += LengthSide(points[0], points[last]);

            return perimeter;
        }
    }
}
