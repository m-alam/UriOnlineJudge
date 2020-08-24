using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, result ;            
            R = double.Parse(Console.ReadLine());
            result = (4.0 / 3) * 3.14159 * (R * R * R);
            Console.WriteLine("VOLUME = {0}", result.ToString("0.000"));
        }
    }
}
