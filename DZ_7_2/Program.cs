using System;

namespace DZ_7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menu = 1;
            do
            {
                Console.WriteLine("Кого создаём? " +
                                  "\n 1. Создать Котеина " +
                                  "\n 2. Создать Хрюнделя ");
                Console.Write("Ваш выбор: ");
                string golos = Console.ReadLine();
                Console.WriteLine();

                switch (golos)
                {
                    case "1":
                        Animal animal = new Cat();
                        Console.WriteLine("Как зовут? ");
                        animal.Name = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Чем будем кормить? " +
                                          "\n 1. Хлебом с картошкой " +
                                          "\n 2. Паштет свинной ");
                        Console.Write("Ваш выбор: ");
                        int eat = Int32.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Сколько порций?");
                        Console.Write("Ваш выбор: ");

                        int eat_count = Int32.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (eat == 1)
                        {
                            animal.Feed(FoodType.PigFood,eat_count);
                        }
                        else
                        {
                            animal.Feed(FoodType.CatFood,eat_count);
                        }
                        Console.WriteLine();
                        animal.SayHello();
                        Console.WriteLine();

                        Console.WriteLine("Возврат в меню? \n 1. Да \n 2. Нет");
                        Console.Write("Ваш выбор: ");
                        menu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        break;

                    case "2":


                        Animal animal2 = new Pig();
                        Console.WriteLine("Как зовут? ");
                        animal2.Name = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Чем будем кормить? " +
                                          "\n 1. Хлебом с картошкой " +
                                          "\n 2. Паштет свинной ");
                        Console.Write("Ваш выбор: ");
                        int eat2 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Сколько порций?");
                        Console.Write("Ваш выбор: ");
                        int eat_count2 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (eat2 == 1)
                        {
                            animal2.Feed(FoodType.PigFood, eat_count2);
                        }
                        else
                        {
                            animal2.Feed(FoodType.CatFood, eat_count2);
                        }
                        Console.WriteLine();
                        animal2.SayHello();
                        Console.WriteLine();

                        Console.WriteLine("Возврат в меню? \n 1. Да \n 2. Нет");
                        Console.Write("Ваш выбор: ");
                        menu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        break;
                }



            } while (menu == 1);
        }

        public abstract class Animal
        {
            public string Name   { get; set; }
            protected double Satiety { get; set; }

            public virtual void Feed(FoodType foodType, int count)
            {
                if (foodType != GetFoodType())
                {
                    Console.WriteLine("Цэ не моя еда");
                    return;
                }

                Satiety += count;
                Console.WriteLine("Майн еда Om-nom-nom");
            }

            public void SayHello()
            {
                Console.WriteLine($"Привет {Name}");
            }
            protected abstract FoodType GetFoodType();
        }

        public class Cat :Animal
        {
            protected override FoodType GetFoodType()
            {
                return FoodType.CatFood;
            }
        }

        public class Pig : Animal
        {
            protected override FoodType GetFoodType()
            {
                return FoodType.PigFood;
            }
        }

        public enum FoodType
        {
            PigFood,
            CatFood
        }
    }
}