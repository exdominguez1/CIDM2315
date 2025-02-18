using System.Diagnostics;

namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        int a = 3, b = 5, max_num;
        if(a > b){
            max_num = a;
        }
        else{
            max_num = b;
        }
        Console.WriteLine($"a = {a}; b = {b}");
        Console.WriteLine($"The Largest number is: {max_num}");

        Console.WriteLine("------------------");

        int N = 5;
        Console.WriteLine($"N is: {N}; Shape is left");
        for(int i = 1 ; i <= N ; i++){
            for(int j = 1 ; j <= i; j++)
            
            {
                if(N>=i)
                    Console.Write('*');
            }
            Console.WriteLine("");
        }

        Console.WriteLine("------------------");

        Console.WriteLine($"N is: {N}; Shape is Right");
		for (int i = 1; i <= N; i++){
			for (int j = 1; j <= N - i; j++)
			{
				Console.Write(" ");
			}
			for (int j = 1; j <= i; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
    }

}
