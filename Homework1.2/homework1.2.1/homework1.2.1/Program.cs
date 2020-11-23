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

namespace homework1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var my = (bankacc)4;
            Console.WriteLine(my);
        }
    }
}
