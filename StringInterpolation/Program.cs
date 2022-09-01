using System;

namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            Console.WriteLine($"{date,40:MMMM d, yyyy}");
            Console.WriteLine($"{date:yyyy.MM.d}");
            Console.WriteLine($"{date:'Day' d 'of' MMMM, yyyy}");
            Console.WriteLine($"{date:'Year:' yyyy, 'Month:' MM, 'Day:' dd}");
            Console.WriteLine($"{date,10:dddd}");
            Console.WriteLine($"{date,10:t}{date,10:dddd}");
            Console.WriteLine($"{date:'h:'hh, 'm:'mm, 's:'ss}");
            Console.WriteLine($"{date:yyyy.MM.dd.hh.mm.ss}");
            var pi = Math.PI;
            Console.WriteLine($"{pi:C2}");
            Console.WriteLine($"{pi,10:.###}");
        }
    }
}
