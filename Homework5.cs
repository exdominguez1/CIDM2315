using System.Security.Cryptography;
using System.Transactions;

namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
       int a = 3, b = 5, max_num1;
        if(a > b){
            max_num1 = a;
        }
        else{
            max_num1 = b;
        }
        Console.WriteLine($"a = {a}; b = {b}");
        Console.WriteLine($"The Largest number is: {max_num1}");

        Console.WriteLine("------------------");

        int c = 7, d = 9, max_num2;
        if(c > d){
            max_num2 = c;
        }
        else{
            max_num2 = d;
        }
        if(max_num1 > max_num2){
            max_num2 = c;
        }
        else{
            max_num2 = d;
        }
        Console.WriteLine($"a = {a}; b = {b} c = {c} d = {d}");
        Console.WriteLine($"The Largest number is: {max_num2}");

        Console.WriteLine("------------------");
    }

    static bool checkAge(int birth_year){
        int age = 2025 - birth_year;
        if(age>=18){
            return true;
        }
        else{
            return false;
        }
    }

    static void createAccount()
    {
        int birth_year;

        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        Console.Write("Enter password again: ");
        string retypedPassword = Console.ReadLine();

        Console.Write("Enter your birthyear: ");
        birth_year = Convert.ToInt32(Console.ReadLine());
        if(checkAge(birth_year))
        {
            if(password==retypedPassword)
            Console.WriteLine("Account is created successfully");
        
            else
                Console.WriteLine("Wrong password");
        }
        else{
            Console.WriteLine("Could not create an account");
        }
        }
    }

