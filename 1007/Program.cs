using System;

namespace _1007
{
    class Program
    {
        static void Main(string[] args)
        {
           
			//Obter dados do usuário
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
			//Printar o resultado
			Console.WriteLine("DIFERENCA = {0}", CalculoProduto(a, b, c, d ));
          
		}

		static double CalculoProduto(double a, double b, double c, double d) {
			return (a * b - c * d );
        }
    }
}
