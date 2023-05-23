using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double a;
                double b;
                double total;
                char oper;

                Console.WriteLine("Введите первое число:");
                if(!double.TryParse(Console.ReadLine(), out a))
                    {
                    Console.WriteLine("Введено неверное число");
                };

                Console.WriteLine("Введите оператор:");
                oper = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                if (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Введено неверное число");
                };
                if (oper =='/' & b==0)
                {
                    Console.WriteLine("На ноль делить нельзя");
                }
                else if (oper == '+')
                {
                    total = a + b;
                    Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
                }

                else if (oper == '-')
                {
                    total = a - b;
                    Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
                }

                else if (oper == '*')
                {
                    total = a * b;
                    Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
                }

                else if (oper == '/')
                {
                    total = a / b;
                    Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
                }
                else
                {
                    Console.WriteLine("Неизвестный оператор.");
                }
               
            }
        }
    }
}
