class Student{
    public static List<Student> student_list = new List<Student>();
    private int stuID { get; set; }
    private string stuName { get; set; }
    public void PrintInfo(){
        Console.WriteLine($"Student ID: {stuID}, Student Name: {stuName}");
    }
    public Student(int inputID, string inputName){
        stuID = inputID;
        stuName = inputName;
        student_list.Add(this);
    }
}