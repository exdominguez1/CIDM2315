class Customer{
    private int id = 0;
    public string name = string.Empty;
    public int age = 0;
    public void printCusInfo(){
        Console.WriteLine($"Customer ID: {id}");
        Console.WriteLine($"Customer name: {name}");
        Console.WriteLine($"Customer age: {age}");

    }

    public Customer(int cus_id, string cus_name, int cus_age){
        id = cus_id;
        name = cus_name;
        age = cus_age;

        this.name = name;
        this.age = age;
    }
    public void ChangeID(int new_id){
        id = new_id;
    }
    public void CompareAge(Customer objCustomer){
        if(this.age >= objCustomer.age){
            Console.WriteLine($"{this.name} is older");
        }else{
            Console.WriteLine($"{objCustomer.name} is older");
        }
    }
}