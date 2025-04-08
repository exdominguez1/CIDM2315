namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");
        foreach(Student stu in Student.student_list){
            stu.PrintInfo();
        }

        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        if(!gradebook.ContainsKey("Tom")){
            gradebook.Add("Tom", 3.3);
        }
        
        Console.WriteLine("\n---Gradebook---");
        foreach(var stu in gradebook){
            Console.WriteLine($"Student GPA: {stu.Key}, Name: {stu.Value}");
        }

        double totalGPA = 0;
        foreach(var stu in gradebook){
            totalGPA += stu.Value;
        }
        double avgGPA = totalGPA/gradebook.Count;
        Console.WriteLine("The average GPA is: "+avgGPA);
    }
}
