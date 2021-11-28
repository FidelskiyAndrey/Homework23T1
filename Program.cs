using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework23T1
{
    class Program
    {
        static void Factor2(int n)
        {
            int result=1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
                Console.WriteLine("Факториал числа {0} равен {1}",i,result);
                Thread.Sleep(1000);
            }
        }

        static async void Factor2Async(int n)
        {
            Console.WriteLine("Метод факториала начал работу");
            await Task.Run(() => Factor2(n));               
            Console.WriteLine("Метод факториала закончил работу");

        }

        static void incr()
        {
            Console.WriteLine("Метод для проверки начал работу");
            for (int i = 1; i < 60; i++)
            {
                int n=i;
                Console.WriteLine(n);
                Thread.Sleep(100);
            }
            Console.WriteLine("Метод для проверки закончил работу");
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Factor2Async(n);
            incr();
            Console.ReadKey();
        }

    }
}
