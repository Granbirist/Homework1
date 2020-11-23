using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum HEI
{
    NSU,
    SPbSU,
    SPbSUT,
    LETI,
    KemGU
}

struct worker
{
    public string name;
    public string surname;
    public decimal salary;
    public HEI job;
}

namespace homework1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            worker Ivan;

            #region ввод данных
            Ivan.name = "Иван";
            Ivan.surname = "Иванов";
            Ivan.salary = 1234.5678M;
            Ivan.job = (HEI)3;
            #endregion

            #region вывод данных
            Console.WriteLine($"Имя сотрудника: {Ivan.name}");
            Console.WriteLine($"Фамилия сотрудника: {Ivan.name}");
            Console.WriteLine($"Зарплата сотрудника: {Ivan.name}");
            Console.WriteLine($"ВУЗ сотрудника: {Ivan.name}");
            #endregion

        }
    }
}
