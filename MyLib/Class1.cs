namespace MyLib
{
    public class Shape
    {
        // Создание виртуального метода нахождения площади фигуры в базовом классе.
        public virtual double Square()
        {
            return -1;
        }
    }
    public class Circle : Shape
    {
        //радиус окружности
        double r;
        //конструктор
        public Circle(double R)
        {
            if (R > 0)
                this.r = R;
            else
            {
                this.r = 0;

            }

        }
        // Переопределение метода Square() в производном классе Circle.
        public override double Square()
        {
            return Math.PI * r * r;
        }
    }
    public class Triangle : Shape
    {
        //длины сторон треугольника
        double a;
        double b;
        double c;

        //конструктор
        public Triangle(double A, double B, double C)
        {
            if (A > 0 && B > 0 && C > 0)
            {
                this.a = A;
                this.b = B;
                this.c = C;
            }
            else
            {
                a = b = c = 0;

            }

        }

        // Переопределение метод Square() в производном классе Circle.
        public override double Square()
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        //проверка на прямоугольный треугольник
        public bool IsRightTtiangle()
        {
            if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                return true;
            else
                return false;
        }
    }
}