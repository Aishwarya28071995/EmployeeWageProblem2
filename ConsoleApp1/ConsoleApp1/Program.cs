using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int WagePerHr = 20;
            Random random = new Random();
            int value = random.Next(0, 2);
            if (value == 0)
            {
                Console.WriteLine("Employee is absent");
            }
            else
            {
                int Salary = WagePerHr * 8;
                Console.WriteLine(Salary);
            }
        }
    }
}
