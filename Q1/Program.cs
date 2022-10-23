using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入數字");
			string input = Console.ReadLine();
			bool success = int.TryParse(input, out int number);
			//int number=Convert.ToInt32(input);
			int sum = 0;
			for (int i = 2; i <= number; i++)
			{
				if (number % i == 0)
				{
					sum += 1;
				}
			}
			if (sum == 2)
			{
				Console.WriteLine(number + "是質數");
			}
			else
			{
				Console.WriteLine(number + "不是質數");

			}

		}
	}
}
