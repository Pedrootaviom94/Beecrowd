using System;

namespace _1003
{
    class Program
    {
        static void Main(string[] args)
		{

			//Obter dados do usuário
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());

			//Printar o resultado
			Console.WriteLine("PROD = {0}", CalculoProduto(a, b));

		}

		static int CalculoProduto(int a, int b) {
			return a * b;
		}
		