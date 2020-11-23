using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, D, x1, x2;
            string s;

            #region ввод данных
            do
            {
                Console.WriteLine("Введите коэффициент a: ");
                s = Console.ReadLine();
            }
            while (Double.TryParse(s, out a) == false);

            do
            {
                Console.WriteLine("Введите коэффициент b: ");
                s = Console.ReadLine();
            }
            while (Double.TryParse(s, out b) == false);

            do
            {
                Console.WriteLine("Введите коэффициент c: ");
                s = Console.ReadLine();
            }
            while (Double.TryParse(s, out c) == false);

            #endregion

            D = b * b - 4 * a * c;

            #region вычисление корней
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Корня два");
                Console.WriteLine($"Первый корень: {x1}");
                Console.WriteLine($"Второй корень: {x2}");
            }
            else if (D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Корень один");
                Console.WriteLine($"Корень: {x1}");
            }
            else Console.WriteLine("Корней нет");
            #endregion
        }
    }
}
