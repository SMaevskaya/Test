// See https://aka.ms/new-console-template for more information
using System;
using MyLib;


    public class OverrideDemo
    {
        static void Main()
        {
            Shape sh = new Shape();

            double rad = -2.5;
            Circle circle1 = new Circle(rad);
            double a = 6;
            double b = 8;
            double c = 10;
            Triangle triangle1 = new Triangle(a, b, c);
            Shape baseRef; // ссылка на базовый класс
            baseRef = sh;
            Console.WriteLine("Shape square is");
            Console.WriteLine(baseRef.Square());
            baseRef = circle1;
            Console.WriteLine("Circle square is");
            Console.WriteLine(baseRef.Square());
            baseRef = triangle1;
            Console.WriteLine("Triangle square is");
            Console.WriteLine(baseRef.Square());
            if (triangle1.IsRightTtiangle())
                Console.WriteLine("Right triangle");
            else Console.WriteLine("Is not right triangle");
        }
    }
