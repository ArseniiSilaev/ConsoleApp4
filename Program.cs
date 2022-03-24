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
            int peopleInQueue = Convert.ToInt32(Console.ReadLine()); 
            int timePerPerson = 10;
            int minutesPerHour = 60;
            int hoursCount = timePerPerson * peopleInQueue / minutesPerHour;
            int minutsCount = timePerPerson * peopleInQueue % minutesPerHour; 
            Console.WriteLine("Вы должны отстоять в очереди " + hoursCount + " часа " + minutsCount + " минут");
        }
    }
}
