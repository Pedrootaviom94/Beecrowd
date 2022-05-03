using System;

namespace _1005
{
    class Program
    {
        static void Main(string[] args)
       	{

			//Obter dados do usuário
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
         
			//Printar o resultado
			Console.WriteLine("MEDIA = {0}", CalculoProduto(a, b));
          
		}

		static double CalculoProduto(double a, double b) {
			return (a * + b * 7.5 ) / (3.5 + 7.5);
        }
        }
        }