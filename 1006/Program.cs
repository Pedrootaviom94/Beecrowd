using System;

namespace _1006
{
    class Program
    {
        static void Main(string[] args)
       {

			//Obter dados do usuário
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
			//Printar o resultado
			Console.WriteLine("MEDIA = {0}", CalculoProduto(a, b, c));

		}

		static double CalculoProduto(double a, double b, double c) {
			return (a * 2 + b * 3 + c * 5) / (2 + 3 + 5);
        }
        }
        }