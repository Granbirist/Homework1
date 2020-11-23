using System;

namespace homework1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ: ");
            int a = Console.Read();

            char ch = (char)(a + 1);
            Console.WriteLine($"Следующий символ: {ch}");
        }
    }
}
