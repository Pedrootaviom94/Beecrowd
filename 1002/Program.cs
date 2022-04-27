using System;

namespace _1002
{
    class Program
    {
        static void Main(string[] args)
        {
             double pi = 3.14159;
            double raio  = double.Parse(Console.ReadLine());
            double area = raio * raio * pi;
            Console.WriteLine("A={0}",area.ToString("F4"));
        }
    }
}
