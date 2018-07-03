using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter a number to determine if it is prime.\t");
			int num = Convert.ToInt32(Console.ReadLine());
			int count = 0;

			for (int i = 1; i < num / 2; i++)
			{
				if ( num % i == 0 )
				{
					count++;
				}
			}
			if (count == 1)
			{
				Console.WriteLine($"\n{num} is prime number.");
			}
			else Console.WriteLine($"{num} is not a prime number.");
			Console.ReadKey();
		}
	}
}
