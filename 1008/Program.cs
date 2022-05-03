using System;

namespace _1008
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
            Console.WriteLine("NUMBER = {0} ", HorasTrabalhadas(a));
			Console.WriteLine("SALARY = U$ {0}", CalculoProduto(b, c));
           
		}
         static double HorasTrabalhadas (double a){
             return (a);
         }

		static double CalculoProduto(double b, double c) {
			return (b * c);
        }
        
    }
}
