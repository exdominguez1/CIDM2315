namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        Professor p1 = new Professor();
        p1.name = "Alice";
        p1.classTeach = "Java";
        p1.setSalary(9000);
        p1.PrintInfo();

        Professor p2 = new Professor();
        p2.name = "Bob";
        p2.classTeach = "Math";
        p2.setSalary(8000);
        p2.PrintInfo();

        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.studentClass = "Java";
        s1.setgrade(90);
        s1.PrintInfo();

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.studentClass = "Math";
        s2.setgrade(80);
        s2.PrintInfo();

        Console.WriteLine($"The salary difference between Alice and Bob is: {p1.getSalary() - p2.getSalary()}");
        Console.WriteLine($"The total grade of Lisa and Tom is: {s1.getGrade() + s2.getGrade()}");
    }
    class Professor
    {
        public string name;
        public string classTeach;
        private double salary = 0;

        public void PrintInfo()
        {
            Console.WriteLine($"Professor {name} teaches {classTeach}, and the salary is: {salary}");
        }

        public void setSalary(double newSalary)
        {
            salary = newSalary;
        }
        public double getSalary()
        {
            return salary;
        }
    }
    class Student{
    public string studentName;
    public string studentClass;
    private double grade = 0;

    public void PrintInfo()
    {
        Console.WriteLine($"Student {studentName} enrolls {studentClass}, and the grade is: {grade}");
    }

    public void setgrade(double newGrade)
    {
        grade = newGrade;
    }
    public double getGrade()
    {
        return grade;
    }
}

}
