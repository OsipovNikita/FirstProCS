using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPro00
{
    internal class DateTimeDemo
    {
        public static string DateTimeNow()
        {
            // Полная дата и время
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            Console.WriteLine($"Time from midnight {now.Hour}:{now.Minute}:{now.Second}");

            // Сколько прошло дней от начала года?
            DateTime today = DateTime.Today;
            Console.WriteLine($"Today is {today.DayOfYear} day of year");

            // Проверка на високосность года
            Console.WriteLine($"Is Leap ? {DateTime.IsLeapYear(now.Year)}");

            Console.WriteLine("Press Enter to stop");
            Console.ReadLine(); 
            
            DateTime stop = DateTime.Now;
            // Интервал времени
            TimeSpan timeDistance = stop - now;

            return ($"Time distance: {timeDistance.TotalHours} hours, {timeDistance.TotalSeconds} seconds"); 
        }
    }
}
