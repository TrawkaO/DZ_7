namespace DZ_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menu = 1;
            do
            {
                Console.WriteLine("Выберите ДЗ " +
                                  "\n 1. Плащадь квадрата " +
                                  "\n 2. Площадь круга " +
                                  "\n 3. Площадь Треугольника " );
                Console.Write("Ваш выбор: ");
                string golos = Console.ReadLine();
                Console.WriteLine();

                switch (golos)
                {
                    case "1":

                        Console.WriteLine("Введите длинну стороны квадрата: ");
                        double side = double.Parse(Console.ReadLine());
                        Square square = new Square(side);
                        Console.WriteLine($"Площадь квардата: {square.GetSqure()}");

                        Console.WriteLine("Возврат в меню? \n 1. Да \n 2. Нет");
                        Console.Write("Ваш выбор: ");
                        menu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        break;

                    case "2":
                        Console.WriteLine("Введите радиус круга: ");
                        double radius = double.Parse(Console.ReadLine());
                        Circle circle = new Circle(radius);
                        Console.WriteLine($"Площадь Круга: {circle.GetSquare()}");

                        Console.WriteLine("Возврат в меню? \n 1. Да \n 2. Нет");
                        Console.Write("Ваш выбор: ");
                        menu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine("Введите высоту треугольника : ");
                        double heght = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите длинну треугольника: ");
                        double length = double.Parse(Console.ReadLine());
                        Delta delta = new Delta(heght, length);

                        Console.WriteLine($"Площадь Треугольника: {delta.GetSquare()}");

                        Console.WriteLine("Возврат в меню? \n 1. Да \n 2. Нет");
                        Console.Write("Ваш выбор: ");
                        menu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        break;
                }



            } while (menu == 1);
          
        }
    }

    public class Figure
    {
        public double GetSquare()
        {
            return 0;
        }
    }

    public class Square : Figure
    {
        private double side;

        public Square(double side_q)
        {
            side = side_q;  
        }

        public double GetSqure()
        {
            return side * side;
        }
    }

    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius_q)
        {
            radius = radius_q;
        }

        public double GetSquare()
        {
            return radius * radius * Math.PI;
        }
    }

    public class Delta : Figure
    {
        private double height;
        private double length;

        public Delta(double height_q, double length_q)
        {
            height = height_q;
            length = length_q;
        }

        public double GetSquare()
        {
            return length * height * 0.5;
        }

    }

    
}