using System;

namespace homework1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите делимое: ");
            string A = Console.ReadLine();
            double a;

            Console.WriteLine("Введите делимое: ");
            string B = Console.ReadLine();
            double b;


            if (Double.TryParse(A, out a) == true && Double.TryParse(B, out b) == true)
            {
                if (b == 0) Console.WriteLine("Нельзя делить на 0!");
                else
                {
                    Console.WriteLine($"Частное: {a / b}");
                }
            }
            else Console.WriteLine("Неправильно введены данные!");


            
        }
    }
}
