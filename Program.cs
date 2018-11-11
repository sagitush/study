using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._11
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("select your option:");
			Console.WriteLine("1-add");
			Console.WriteLine("2-sub");
			Console.WriteLine("3-mul");
			Console.WriteLine("4-div");
			Console.WriteLine("5-exit");
			int opt = Convert.ToInt32(Console.ReadLine());
			
			while (opt != 5)
			{
				Console.WriteLine("choose 2 numbers");
				int a = Convert.ToInt32(Console.ReadLine());
				int b = Convert.ToInt32(Console.ReadLine());
				if (opt==1)
				{
					int add = a + b;
					Console.WriteLine(add);
				}
				else if (opt==2)
				{
					int sub = a - b;
					Console.WriteLine(sub);
				}
				else if (opt==3)
				{
					int mul = a * b;
					Console.WriteLine(mul);
				}
				else if(opt==4)
				{
					int div = a / b;
					Console.WriteLine(div);
				}
				else
				{
					Console.WriteLine("wrong option");
				}
				Console.WriteLine("select your option:");
				Console.WriteLine("1-add");
				Console.WriteLine("2-sub");
				Console.WriteLine("3-mul");
				Console.WriteLine("4-div");
				Console.WriteLine("5-exit");
				opt = Convert.ToInt32(Console.ReadLine());
			}
			


		}
	}
}
