using System.Data;

namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input an integer");
        int N = Convert.ToInt16(Console.ReadLine());
    int a = 0;
    for (int i = 1; i <= N; i++) {
        if (N % i == 0) {
            a++;
        }
    }
    if (a == 2) {
        Console.WriteLine("N is a Prime ");
    }
    else {
        Console.WriteLine("N is Not-Prime");
    }


        Console.WriteLine("Assign an int value to N:");
        int n = Convert.ToInt16(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write('#');
            }
            Console.WriteLine("");
        }
            
        Console.WriteLine("Assign an int value to N:");
        int nu = Convert.ToInt16(Console.ReadLine());
        for (int row = 0; row < nu; row++){
            for (int col = 0; col < nu; col++)
            {
                if(row>=col)
                Console.Write('*');
            }
            Console.WriteLine("");
            }
    }
}