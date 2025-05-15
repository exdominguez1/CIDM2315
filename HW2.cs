namespace HW2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a letter grade:");
        string gradeinput = Console.ReadLine();

        switch (gradeinput)
        {
            case "A":
                Console.WriteLine("GPA point: 4");
                break;
            case "B":
                Console.WriteLine("GPA point: 3");
                break;
            case "C":
                Console.WriteLine("GPA point: 2");
                break;
            case "D":
                Console.WriteLine("GPA point: 1");
                break;
            case "F":
                Console.WriteLine("GPA point: 0");
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
        }

        Console.WriteLine("Please input the first num:");
        string numone = Console.ReadLine();
        int num1 = Convert.ToInt16(numone);

        Console.WriteLine("Please input the second num:");
        string numtwo = Console.ReadLine();
        int num2 = Convert.ToInt16(numtwo);

        Console.WriteLine("Please input the third num:");
        string numthree = Console.ReadLine();
        int num3 = Convert.ToInt16(numthree);

        if (num1 < num2)
        {
            if (num1 < num3)
            {
                Console.WriteLine($"The smallest num: {num1}");
            }
            else
            {
                Console.WriteLine($"The smallest num: {num3}");
            }
        }
        else
        {
            if (num2 < num3)
            {
                Console.WriteLine($"The smallest num: {num2}");
            }
            else{
                Console.WriteLine($"The smallest num: {num3}");
            }
        }
    }
}
