using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum bankacc
{
    current,
    credit,
    deposite,
    budgetary,
    social_pay
}
 struct account
{
    public int number;
    public bankacc type;
    public decimal balance;
}

namespace homework1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            account my;

            #region ввод данных
            my.number = 1234;
            my.type = (bankacc)3;
            my.balance = 1234.5678M;
            #endregion

            #region вывод данных структуры
            Console.WriteLine($"Номер счета: {my.number}");
            Console.WriteLine($"Тип счета: {my.type}");
            Console.WriteLine($"Баланс счета: {my.balance}");
            #endregion
        }
    }
}
