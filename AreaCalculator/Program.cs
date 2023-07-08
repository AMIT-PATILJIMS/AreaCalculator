using System;

namespace AreaCalculator
{
    public static class Program
    {
        public static int Rectangle(int length,int breadth)
        {
            return length * breadth;
        }
        public static double Circle(int radius)
        {
            return 3.14 * radius * radius;
        }
        public static int Square(int side)
        {
            return side * side;
        }
        public static int Triangle(int baseOfTriangle, int height)
        {
            return baseOfTriangle * height / 2;
        }
    }
}