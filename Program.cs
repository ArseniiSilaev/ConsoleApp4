using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество людей в очереди: "); 
            int N = Convert.ToInt32(Console.ReadLine()); 
            int hours = 10 * N / 60; 
            int minuts = 10 * N % 60; 
            Console.WriteLine("Вы должны отстоять в очереди " + hours + " часа " + minuts + " минут");

        }
    }
}