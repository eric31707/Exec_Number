using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入數字");
			string input = Console.ReadLine();
			bool success = int.TryParse(input, out int number);
			Console.WriteLine("請輸入數字");
			string input1 = Console.ReadLine();
			bool success1 = int.TryParse(input1, out int number1);

			for (int i = 2; i <= number1; i++)
			{
				bool primeornot = true;
				for (int j = 2; j < i; j++)
				{
					if (i % j == 0)
					{
						primeornot = false;
						break;
					}
				}
				if (primeornot)
				{
					Console.WriteLine(i);
				}

			}








			//Console.WriteLine(number1);

		}
	}
}
